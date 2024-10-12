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

        // Método para ajustar automáticamente el tamaño de las columnas
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

            // Verificar si hay al menos un ítem seleccionado en el ListView
            if (OrdenDeSeleccionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un ítem para generar la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se selecciona ningún ítem
            }

            if (int.TryParse(idOrdenText, out numeroOrden))
            {
                // Confirmar órdenes seleccionadas
                var resultado = MessageBox.Show("¿Está seguro de que desea generar la orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Lista temporal para almacenar los items seleccionados
                    List<ListViewItem> itemsAEliminar = new List<ListViewItem>();
                    List<string> detallesProductos = new List<string>();

                    // Iterar sobre los elementos seleccionados en el ListView
                    foreach (ListViewItem item in OrdenDeSeleccionListView.SelectedItems)
                    {
                        itemsAEliminar.Add(item); // Agregar el item a la lista temporal

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

                    // Eliminar los items seleccionados del ListView
                    foreach (var item in itemsAEliminar)
                    {
                        OrdenDeSeleccionListView.Items.Remove(item);
                    }

                    // Mostrar el mensaje de éxito con detalles de los productos
                    string detalles = string.Join("\n", detallesProductos);
                    MessageBox.Show($"Orden número {numeroOrden} generada con éxito!\n\nDetalles de los productos:\n{detalles}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el formulario
                    IDClienteTextBox.Clear(); // Limpiar el TextBox de IDCliente
                    IDOPTextBox.Clear(); // Limpiar el TextBox de IDOperación
                    OrdenDeSeleccionListView.Items.Clear(); // Limpiar el ListView

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

            // Verificar si se ha ingresado al menos un ID
            if (string.IsNullOrWhiteSpace(idClienteInput) && string.IsNullOrWhiteSpace(idOrdenInput))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente o un ID de orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpiar los TextBoxes
                IDClienteTextBox.Clear();
                IDOPTextBox.Clear();

                // Recargar la lista original de órdenes
                CargarListaOrdenes(); // Método que recarga todas las órdenes originales
                return; // Salir del método si no se ingresa ningún ID
            }

            // Limpiar el ListView antes de agregar nuevos elementos
            OrdenDeSeleccionListView.Items.Clear();

            // Filtrar las órdenes
            var ordenesFiltradas = model.ListaOrdenesSeleccion.AsQueryable();

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

            // Ordenar por prioridad
            ordenesFiltradas = ordenesFiltradas.OrderBy(orden => orden.Prioridad);

            // Verificar si se encontraron órdenes
            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No se encontraron órdenes para el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBoxes
                IDClienteTextBox.Clear();
                IDOPTextBox.Clear();

                // Recargar la lista original de órdenes
                CargarListaOrdenes(); // Método que recarga todas las órdenes originales
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
            // Verificar si hay un IDCliente o IDOrden ingresado
            if (string.IsNullOrWhiteSpace(IDClienteTextBox.Text) && string.IsNullOrWhiteSpace(IDOPTextBox.Text))
            {
                MessageBox.Show("No hay un ID de cliente o un ID de orden ingresado para reiniciar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no se ha ingresado ningún ID
            }

            // Limpiar los TextBox donde se ingresaron los IDs
            IDClienteTextBox.Clear();
            IDOPTextBox.Clear();

            // Limpiar el ListView antes de volver a cargar todas las órdenes
            OrdenDeSeleccionListView.Items.Clear();

            // Cargar todas las órdenes de selección en el ListView
            CargarListaOrdenes(); // Método que recarga todas las órdenes originales
        }


    }
}
