using GrupoC.Tp3.CDU1.BuscarCliente;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoC.Tp3.CDU1
{
    public partial class BuscarClienteForm : Form
    {
        private BuscarClienteModel model = new(); //creamos una instancia de la clase BuscarClienteModel

        public BuscarClienteForm() //Inicializa
        {
            InitializeComponent();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e) //Se carga la lista directamente
        {
            ClientesListView.Enabled = true;
            CargarLista(); //Llama al procedimiento
        }
        private void CargarLista()
        {

            foreach (var Clientes in model.ListaClientes) //Cargar a la lista.
            {
                ListViewItem item = new ListViewItem();
                item.Text = Clientes.Id.ToString();
                item.SubItems.Add(Clientes.Nombre);
                item.SubItems.Add(Clientes.CUIT);
                item.SubItems.Add(Clientes.Direccion);
                item.SubItems.Add(Clientes.Telefono);
                item.SubItems.Add(Clientes.Email);
                ClientesListView.Items.Add(item);
            }
        }
        private void CancelarButton_Click(object sender, EventArgs e) //Boton Cancelar y vuelve al menú
        {
            this.Close();
        }
        private void BuscarButton_Click(object sender, EventArgs e) //Boton Buscar CUIT
        {

            if (!string.IsNullOrEmpty(CuitTextBox.Text)) //Aca van las validaciones 
            {
                string cuitBuscado = CuitTextBox.Text.Trim();

                if (model.IsValidCuit(cuitBuscado)) // Función IsValidCuit para validar el CUIT
                {
                    var cliente = model.BuscarClientePorCuit(cuitBuscado); // Llama al metodo de busqueda

                    if (cliente != null)
                    {
                        // Limpia la lista antes de mostrar el cliente encontrado
                        ClientesListView.Items.Clear();

                        //Llamo al metodo que carga ese cliente
                        AgregarClienteALaLista(cliente);
                    }
                    //if (XXXXXXXXX)
                    //{

                    //    if (XXXXXXXXX)
                    //    {
                    //        //Busca el CUIT y muestra datos completos en lista
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("CUIT no encontrado");
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Por favor, ingrese un número de CUIT válido");
                    //}
                }
                else
                {
                    MessageBox.Show("CUIT no encontrado");
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
            ClientesListView.Items.Add(item);
        }
        private void SeleccionarButton_Click(object sender, EventArgs e) // Boton Seleccionar
        {
            // Verificar si hay un cliente seleccionado en el ListView
            if (ClientesListView.SelectedItems.Count > 0)
            {
                // Obtener el cliente seleccionado
                var selectedItem = ClientesListView.SelectedItems[0];

                // Extraer la información del cliente
                int id = int.Parse(selectedItem.SubItems[0].Text); // ID

                // Debe pasar el cliente seleccionado a Form2
                // Crear una instancia de GenerarOrdenDePreparacionForm
                GenerarOrdenDePreparacionForm generarOrdenForm = new GenerarOrdenDePreparacionForm();

                // Asignar los valores a las propiedades
                generarOrdenForm.Id = id;

                // Mostrar mensaje de éxito
                MessageBox.Show("Cliente seleccionado con éxito.");
                // Mostrar el formulario2
                generarOrdenForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.");
            }
        }

    }    
    
}