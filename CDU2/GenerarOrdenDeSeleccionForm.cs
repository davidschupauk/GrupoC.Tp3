using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU2
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        private int nextId = 1; // Campo para llevar el conteo del ID
        private GenerarOrdenDeSeleccionModel model = new(); // Creamos una instancia de la clase GenerarOrdenDeSeleccionModel
        private OrdenesDeSeleccion ordenSeleccionada; // Campo para almacenar la orden seleccionada

        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        // Método para generar un ID
        private int GenerateID()
        {
            return nextId++;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una orden
            if (ListadoOPListView.SelectedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar una orden para generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }

            // Mostrar el cuadro de confirmación
            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres generar la orden?",
                "Confirmar Orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario selecciona 'Yes', confirmar la orden
            if (confirmacion == DialogResult.Yes)
            {
                // Lógica para confirmar la orden
                MessageBox.Show("La orden ha sido generada correctamente.");
            }
            else
            {
                // Si el usuario selecciona 'No', no hacer nada
                MessageBox.Show("La confirmación ha sido cancelada.");
            }
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = FechaDateTimePicker.Value.Date; // Solo tomamos la fecha sin la hora

            // Limpiar el ListView antes de agregar los elementos filtrados
            ListadoOPListView.Items.Clear();

            // Filtrar la lista de órdenes según la fecha seleccionada
            var ordenesFiltradas = model.ListaOrdenesSeleccion
                .Where(orden => orden.Fecha.Date == fechaSeleccionada)
                .ToList();

            // Si se encuentran órdenes con la fecha seleccionada
            if (ordenesFiltradas.Any())
            {
                foreach (var orden in ordenesFiltradas)
                {
                    // Crear un nuevo ListViewItem para cada orden filtrada
                    ListViewItem item = new ListViewItem(orden.IDCliente.ToString());
                    item.SubItems.Add(orden.NumeroOrden.ToString());
                    item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(orden.Transportista);
                    item.SubItems.Add(orden.Estado);

                    // Añadir el item a ListadoOPListView
                    ListadoOPListView.Items.Add(item);
                }
            }
            else
            {
                // Si no se encuentran órdenes con la fecha seleccionada, mostrar un mensaje
                MessageBox.Show("No se encontraron órdenes con la fecha seleccionada.", "Filtrar Órdenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            // Generar un ID único para la orden de selección
            IDOSTextBox.Text = GenerateID().ToString();

            // Configurar el DateTimePicker
            FechaDateTimePicker.Format = DateTimePickerFormat.Custom;
            FechaDateTimePicker.CustomFormat = "dd/MM/yyyy"; // Formato personalizado

            // Cargar la lista de órdenes de selección en el ListView
            CargarListaOrdenes();
        }

        // Método para cargar la lista de órdenes de selección
        private void CargarListaOrdenes()
        {
            // Limpiamos el ListView antes de agregar nuevos elementos
            ListadoOPListView.Items.Clear();

            // Cargar las órdenes de selección en el ListView
            foreach (var orden in model.ListaOrdenesSeleccion)
            {
                ListViewItem item = new ListViewItem(orden.IDCliente.ToString()); // Primera columna: ID del cliente
                item.SubItems.Add(orden.NumeroOrden.ToString()); // Segunda columna: Número de la orden
                item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy")); // Tercera columna: Fecha
                item.SubItems.Add(orden.Transportista); // Cuarta columna: Transportista
                item.SubItems.Add(orden.Estado); // Quinta columna: Estado de la orden

                // Asignar el objeto OrdenesDeSeleccion completo al Tag del ListViewItem (opcional)
                item.Tag = orden;

                // Agregar el item al ListView
                ListadoOPListView.Items.Add(item);
            }
        }

        // Evento para manejar el clic en el ListView
        private void ListadoOPListView_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar si se hizo clic en un item
            if (ListadoOPListView.SelectedItems.Count > 0)
            {
                // Obtener el item seleccionado
                ListViewItem item = ListadoOPListView.SelectedItems[0];

                // Asignar la orden seleccionada al campo
                ordenSeleccionada = (OrdenesDeSeleccion)item.Tag;
            }
        }
    }
}
