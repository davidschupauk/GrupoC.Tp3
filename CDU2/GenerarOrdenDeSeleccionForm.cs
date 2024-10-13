using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC.Tp3.CDU2
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        private GenerarOrdenDeSeleccionModel model = new(); // Creamos una instancia de la clase GenerarOrdenDeSeleccionModel
        private int nextId = 1; // Campo para llevar el conteo del ID

        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        // Método para generar un ID
        private int GenerateID()
        {
            return nextId++;
        }

        private void GenerarOrdenDeSeleccionForm_Load_1(object sender, EventArgs e)
        {
            // Generar un ID único para la orden de selección + fondo gris
            IDOSTextBox.Text = GenerateID().ToString();
            IDOSTextBox.ReadOnly = true;
            IDOSTextBox.Enabled = false; // deshabilita el control por completo

            // Configurar DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.MinDate = DateTime.Today; // Solo permite seleccionar desde hoy

            // Cargar la lista de órdenes de selección en el ListView
            CargarListaOrdenes();
        }
        private void CargarListaOrdenes()
        {
            // Limpiar el ListView antes de agregar nuevos elementos
            OrdenDeSeleccionListView.Items.Clear();

            // Definir el orden de prioridades
            var prioridades = new Dictionary<string, int>
            {
                { "Alta", 1 },
                { "Media", 2 },
                { "Baja", 3 }
            };

            // Ordenar la lista de órdenes por prioridad utilizando el diccionario
            var ordenesOrdenadas = model.ListaOrdenesSeleccion
                .OrderBy(orden => prioridades[orden.Prioridad])
                .ToList();

            // Cargar las órdenes de selección en el ListView
            foreach (var orden in ordenesOrdenadas)
            {
                // Crear un nuevo item para el ListView
                ListViewItem item = new ListViewItem(orden.NumeroOrden.ToString()); // Primera columna: Número de la orden
                item.SubItems.Add(orden.IDCliente.ToString()); // Segunda columna: ID del cliente
                item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy")); // Tercera columna: Fecha
                item.SubItems.Add(orden.Transportista); // Cuarta columna: Transportista
                item.SubItems.Add(orden.Prioridad); // Quinta columna: Prioridad de la orden

                // Asignar el objeto OrdenesDeSeleccion completo al Tag del ListViewItem
                item.Tag = orden;

                // Agregar el item al ListView
                OrdenDeSeleccionListView.Items.Add(item);
            }

            // Ajustar el tamaño de las columnas
            AjustarTamañoColumnas();
        }

        // Método para ajustar automáticamente el tamaño de las columnas OrdenDeSeleccionListView
        private void AjustarTamañoColumnas()
        {
            foreach (ColumnHeader column in OrdenDeSeleccionListView.Columns)
            {
                column.Width = -2;
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la orden desde el TextBox
            string idOrdenText = IDOSTextBox.Text; // TextBox
            int numeroOrden;

            // Verificar si hay ítems en el ListView de órdenes seleccionadas
            if (OrdenDeSeleccion2ListView.Items.Count == 0)
            {
                MessageBox.Show("No hay ítems en la lista de órdenes para generar la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no hay ítems
            }

            if (int.TryParse(idOrdenText, out numeroOrden))
            {
                // Confirmar generación de la orden
                var resultado = MessageBox.Show("¿Está seguro de que desea generar la orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Lista temporal para almacenar los items a eliminar
                    List<string> detallesProductos = new List<string>();

                    // Iterar sobre los elementos en el ListView de órdenes seleccionadas
                    foreach (ListViewItem item in OrdenDeSeleccion2ListView.Items)
                    {
                        // Obtener el IDCliente del item
                        var ordenSeleccionada = (OrdenesDeSeleccion)item.Tag;

                        // Buscar en la lista de órdenes de preparación
                        var ordenPreparacion = model.ListaOrdenesPreparacion
                            .FirstOrDefault(op => op.IDCliente == ordenSeleccionada.IDCliente && op.Codigo == ordenSeleccionada.NumeroOrden);

                        if (ordenPreparacion != null)
                        {
                            detallesProductos.Add($"Producto: {ordenPreparacion.Producto}, Cantidad: {ordenPreparacion.Cantidad}, Ubicación: {ordenPreparacion.Ubicacion}");
                        }
                    }

                    // Eliminar los items confirmados de OrdenDeSeleccionListView
                    foreach (ListViewItem item in OrdenDeSeleccion2ListView.Items)
                    {
                        var ordenSeleccionada = (OrdenesDeSeleccion)item.Tag;
                        var itemToRemove = OrdenDeSeleccionListView.Items
                            .Cast<ListViewItem>()
                            .FirstOrDefault(i => ((OrdenesDeSeleccion)i.Tag).IDCliente == ordenSeleccionada.IDCliente && ((OrdenesDeSeleccion)i.Tag).NumeroOrden == ordenSeleccionada.NumeroOrden);

                        if (itemToRemove != null)
                        {
                            OrdenDeSeleccionListView.Items.Remove(itemToRemove);
                        }
                    }

                    // Mostrar el mensaje de éxito con detalles de los productos
                    string detalles = string.Join("\n", detallesProductos);
                    MessageBox.Show($"Orden número {numeroOrden} generada con éxito!\n\nDetalles de los productos:\n{detalles}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el formulario
                    IDClienteTextBox.Clear(); // Limpiar el TextBox de IDCliente
                    IDOPTextBox.Clear(); // Limpiar el TextBox de IDOperación
                    OrdenDeSeleccion2ListView.Items.Clear(); // Limpiar el ListView de órdenes generadas

                    // Generar el nuevo número correlativo para la próxima orden
                    int nuevoNumeroOrden = numeroOrden + 1;
                    IDOSTextBox.Text = nuevoNumeroOrden.ToString(); // Actualizar el TextBox de IDOrden

                    // Recargar la lista original de órdenes
                    CargarListaOrdenes();

                }
            }
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            // Obtener los IDs ingresados por el usuario
            string idClienteInput = IDClienteTextBox.Text; // Toma el TextBox de IDCliente
            string idOrdenInput = IDOPTextBox.Text; // Toma el TextBox de IDOrden
            DateTime? fechaSeleccionada = dateTimePicker1.Checked ? (DateTime?)dateTimePicker1.Value : null; // Toma la fecha si está seleccionada
            string prioridadInput = PrioridadComboBox.SelectedItem?.ToString(); // Toma la prioridad seleccionada en el ComboBox

            // Verificar si se ha ingresado al menos un ID, se ha seleccionado una fecha o una prioridad
            if (string.IsNullOrWhiteSpace(idClienteInput) && string.IsNullOrWhiteSpace(idOrdenInput) && !fechaSeleccionada.HasValue && string.IsNullOrWhiteSpace(prioridadInput))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente, un ID de orden, seleccione una fecha o una prioridad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpiar los TextBoxes y el DateTimePicker
                IDClienteTextBox.Clear();
                IDOPTextBox.Clear();
                dateTimePicker1.ResetText(); // Esto hará que se muestre vacío
                PrioridadComboBox.SelectedIndex = -1; // Reiniciar el ComboBox

                return; // Salir del método si no se ingresa nada
            }

            // Limpiar el ListView antes de agregar nuevos elementos
            OrdenDeSeleccionListView.Items.Clear();

            // Filtrar las órdenes
            var ordenesFiltradas = model.ListaOrdenesSeleccion.AsQueryable();

            // Obtener los IDs de los ítems ya seleccionados en OrdenDeSeleccion2ListView
            var idsSeleccionados = OrdenDeSeleccion2ListView.Items
                .Cast<ListViewItem>()
                .Select(item => ((OrdenesDeSeleccion)item.Tag).NumeroOrden)
                .ToList();

            // Filtrar por IDCliente si se ha ingresado
            if (!string.IsNullOrWhiteSpace(idClienteInput))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.IDCliente.ToString() == idClienteInput);
            }

            // Filtrar por IDOrden si se ha ingresado
            if (!string.IsNullOrWhiteSpace(idOrdenInput))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.NumeroOrden.ToString() == idOrdenInput);
            }

            // Filtrar por fecha si se ha seleccionado
            if (fechaSeleccionada.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.Fecha.Date == fechaSeleccionada.Value.Date);
            }

            // Filtrar por prioridad si se ha seleccionado
            if (!string.IsNullOrWhiteSpace(prioridadInput))
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => orden.Prioridad.ToString() == prioridadInput);
            }

            // Excluir los ítems seleccionados en OrdenDeSeleccion2ListView
            if (idsSeleccionados.Any())
            {
                ordenesFiltradas = ordenesFiltradas.Where(orden => !idsSeleccionados.Contains(orden.NumeroOrden));
            }

            // Verificar si se encontraron órdenes
            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No se encontraron órdenes para los criterios ingresados o todos los resultados ya están seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBoxes y el DateTimePicker
                IDClienteTextBox.Clear();
                IDOPTextBox.Clear();
                dateTimePicker1.ResetText(); // Esto hará que se muestre vacío
                PrioridadComboBox.SelectedIndex = -1; // Reiniciar el ComboBox

                return; // Salir del método si no se encuentran órdenes
            }

            // Cargar las órdenes filtradas en el ListView
            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOrden.ToString())
                {
                    ImageIndex = 0
                };
                item.SubItems.Add(orden.IDCliente.ToString());
                item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(orden.Transportista);
                item.SubItems.Add(orden.Prioridad);
                item.Tag = orden;

                OrdenDeSeleccionListView.Items.Add(item);
            }

            // Ajustar el tamaño de las columnas
            AjustarTamañoColumnas();
        }



        private void ReiniciarFiltroButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay un IDCliente, IDOrden o fecha seleccionada
            if (string.IsNullOrWhiteSpace(IDClienteTextBox.Text) && string.IsNullOrWhiteSpace(IDOPTextBox.Text)
                && string.IsNullOrWhiteSpace(PrioridadComboBox.SelectedItem?.ToString())
                && !dateTimePicker1.Checked)
            {
                MessageBox.Show("No hay un ID de cliente, ID de orden, prioridad o fecha seleccionada para reiniciar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay nada que limpiar
            }

            // Limpiar los TextBox donde se ingresaron los IDs
            IDClienteTextBox.Clear();
            IDOPTextBox.Clear();

            // Limpiar el ComboBox de prioridad
            PrioridadComboBox.SelectedIndex = -1; // O PrioridadComboBox.ResetText(); si quieres restablecer el texto

            // Limpiar el DateTimePicker
            dateTimePicker1.ResetText(); // Restablecer el DateTimePicker

            // Limpiar el ListView antes de volver a cargar todas las órdenes
            OrdenDeSeleccionListView.Items.Clear();

            // Cargar todas las órdenes de selección en el ListView
            CargarListaOrdenes(); // Método que recarga todas las órdenes originales
        }

        private void AgregarTodasButton_Click(object sender, EventArgs e)
        {
            // Crear una lista temporal para almacenar los ítems a eliminar
            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();

            // Iterar sobre los elementos en OrdenDeSeleccionListView
            foreach (ListViewItem item in OrdenDeSeleccionListView.Items)
            {
                // Clonar el ítem para agregarlo al segundo ListView
                ListViewItem nuevoItem = (ListViewItem)item.Clone();

                // Agregar el nuevo ítem a OrdenDeSeleccion2ListView
                OrdenDeSeleccion2ListView.Items.Add(nuevoItem);

                // Agregar el ítem original a la lista de eliminación
                itemsAEliminar.Add(item);
            }

            // Eliminar los ítems originales de OrdenDeSeleccionListView
            foreach (var item in itemsAEliminar)
            {
                OrdenDeSeleccionListView.Items.Remove(item);
            }

            // Ajustar automáticamente las columnas del ListView de destino
            OrdenDeSeleccion2ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            OrdenDeSeleccion2ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Ajustar por el tamaño del encabezado también
        }



        private void AgregarSeleccionadasButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay ítems seleccionados en el ListView de selección
            if (OrdenDeSeleccionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un ítem para agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay ítems seleccionados
            }

            // Lista temporal para almacenar los ítems a eliminar
            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();

            // Iterar sobre los ítems seleccionados y agregarlos al segundo ListView
            foreach (ListViewItem item in OrdenDeSeleccionListView.SelectedItems)
            {
                // Clonar el ítem para evitar referencias compartidas
                ListViewItem nuevoItem = (ListViewItem)item.Clone();

                // Agregar el nuevo ítem al ListView de destino
                OrdenDeSeleccion2ListView.Items.Add(nuevoItem);

                // Agregar el ítem original a la lista de eliminación
                itemsAEliminar.Add(item);
            }

            // Eliminar los ítems seleccionados del primer ListView
            foreach (var item in itemsAEliminar)
            {
                OrdenDeSeleccionListView.Items.Remove(item);
            }

            // Ajustar automáticamente las columnas del ListView de destino
            OrdenDeSeleccion2ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            OrdenDeSeleccion2ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Ajustar por el tamaño del encabezado también
        }

        private void QuitarTodasButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay ítems en el ListView de selección 2
            if (OrdenDeSeleccion2ListView.Items.Count == 0)
            {
                MessageBox.Show("No hay ítems para quitar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir si no hay ítems
            }

            // Iterar sobre los ítems en OrdenDeSeleccion2ListView y moverlos a OrdenDeSeleccionListView
            List<ListViewItem> itemsAMover = new List<ListViewItem>();

            foreach (ListViewItem item in OrdenDeSeleccion2ListView.Items)
            {
                // Clonar el ítem para evitar referencias compartidas
                ListViewItem nuevoItem = (ListViewItem)item.Clone();
                itemsAMover.Add(nuevoItem);
            }

            // Agregar los ítems clonados al ListView original
            foreach (ListViewItem item in itemsAMover)
            {
                OrdenDeSeleccionListView.Items.Add(item);
            }

            // Limpiar el ListView de destino
            OrdenDeSeleccion2ListView.Items.Clear();
        }


        private void QuitarSeleccionadasButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay ítems seleccionados en el ListView de selección 2
            if (OrdenDeSeleccion2ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un ítem para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay ítems seleccionados
            }

            // Crear una lista temporal para almacenar los ítems a mover
            List<ListViewItem> itemsAMover = new List<ListViewItem>();

            // Iterar sobre los ítems seleccionados en OrdenDeSeleccion2ListView
            foreach (ListViewItem item in OrdenDeSeleccion2ListView.SelectedItems)
            {
                // Clonar el ítem para evitar referencias compartidas
                ListViewItem nuevoItem = (ListViewItem)item.Clone();
                itemsAMover.Add(nuevoItem);
            }

            // Agregar los ítems clonados al ListView original
            foreach (ListViewItem item in itemsAMover)
            {
                OrdenDeSeleccionListView.Items.Add(item);
            }

            // Eliminar los ítems seleccionados del ListView de destino
            foreach (ListViewItem item in OrdenDeSeleccion2ListView.SelectedItems)
            {
                OrdenDeSeleccion2ListView.Items.Remove(item);
            }
        }

    }
}
