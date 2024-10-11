using GrupoC.Tp3.CDU1.BuscarCliente;
using System;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU1
{
    public partial class BuscarClienteForm : Form
    {
        private BuscarClienteModel model = new(); // Creamos una instancia de la clase BuscarClienteModel

        public int ClienteSeleccionadoId { get; private set; } // Propiedad para almacenar el ID del cliente seleccionado

        public BuscarClienteForm() // Inicializa
        {
            InitializeComponent();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e) // Se carga la lista directamente
        {
            ClientesListView.Enabled = true;
            CargarLista(); // Llama al procedimiento
        }

        private void CargarLista()
        {
            foreach (var cliente in model.ListaClientes) // Cargar a la lista.
            {
                ListViewItem item = new ListViewItem();
                item.Text = cliente.Id.ToString();
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.CUIT);
                item.SubItems.Add(cliente.Direccion);
                item.SubItems.Add(cliente.Telefono);
                item.SubItems.Add(cliente.Email);
                item.Tag = cliente; // Guardar el objeto cliente en el Tag para fácil acceso
                ClientesListView.Items.Add(item);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e) // Botón Cancelar y vuelve al menú
        {
            this.Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e) // Botón Buscar CUIT
        {
            if (!string.IsNullOrEmpty(CuitTextBox.Text)) // Validaciones
            {
                string cuitBuscado = CuitTextBox.Text.Trim();

                if (model.IsValidCuit(cuitBuscado)) // Función IsValidCuit para validar el CUIT
                {
                    var cliente = model.BuscarClientePorCuit(cuitBuscado); // Llama al método de búsqueda

                    if (cliente != null)
                    {
                        ClientesListView.Items.Clear();

                        AgregarClienteALaLista(cliente);
                    }
                    else
                    {
                        MessageBox.Show("CUIT no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de CUIT válido");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de CUIT válido");
            }
        }

        private void AgregarClienteALaLista(Clientes cliente)
        {
            ListViewItem item = new ListViewItem();
            item.Text = cliente.Id.ToString();
            item.SubItems.Add(cliente.Nombre);
            item.SubItems.Add(cliente.CUIT);
            item.SubItems.Add(cliente.Direccion);
            item.SubItems.Add(cliente.Telefono);
            item.SubItems.Add(cliente.Email);
            item.Tag = cliente;
            ClientesListView.Items.Add(item);
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (ClientesListView.SelectedItems.Count > 0)
            {
                var selectedItem = ClientesListView.SelectedItems[0];
                var cliente = (Clientes)selectedItem.Tag;

                ClienteSeleccionadoId = cliente.Id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.");
            }
        }
    }
}
