using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU1
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        private GenerarOrdenDePreparacionModel model = new();
        private List<Producto> productosSeleccionados = new();
        public int Id { get; set; }

        public int ClienteSeleccionadoId { get; private set; } // Propiedad para almacenar el ID del cliente seleccionado

        private int nextId = 1;

        private void ProductosClienteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductosClienteListView.SelectedItems.Count > 0)
            {
                AgregarButton.Enabled = true;
            }
            else
            {
                AgregarButton.Enabled = false;
            }
        }

        public GenerarOrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.MinDate = DateTime.Today;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 10000;
            numericUpDown1.Increment = 1;
            IDTextBox.Text = GenerateID().ToString();

            CargarListaProductos(Id);

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
            foreach (ColumnHeader column in ClientesListView.Columns)
            {
                column.Width = -2; // Ajusta el ancho de la columna al contenido
            }
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (ClientesListView.SelectedItems.Count > 0)
            {
                var selectedItem = ClientesListView.SelectedItems[0];
                var cliente = (Clientes)selectedItem.Tag;

                ClienteSeleccionadoId = cliente.Id;

                this.DialogResult = DialogResult.OK;
                ProductosClienteListView.Items.Clear();
                ListViewItem selectedItem2 = ClientesListView.SelectedItems[0];
                var clienteSeleccionado = model.ListaProductos.Where(cliente => cliente.IDCliente.ToString() == selectedItem.Text).ToList();

                foreach (var cliente2 in clienteSeleccionado)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = cliente2.Codigo.ToString();
                    item.SubItems.Add(cliente2.Descripcion);
                    item.SubItems.Add(cliente2.Posicion);
                    item.SubItems.Add(cliente2.Cantidad.ToString());
                    item.Tag = cliente2;

                    ProductosClienteListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.");
            }
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

        private int GenerateID()
        {
            return nextId++;
        }


        private void CargarListaProductos(int idCliente)
        {
            var productosFiltrados = FiltrarProductosPorCliente(model.ListaProductos, idCliente);

            ProductosClienteListView.Items.Clear();

            foreach (var producto in productosFiltrados)
            {
                // Crear un nuevo ListViewItem
                ListViewItem item = new ListViewItem(producto.Codigo.ToString()); // Primera columna: Código del producto
                item.SubItems.Add(producto.Descripcion); // Segunda columna: Descripción del producto
                item.SubItems.Add(producto.Posicion); // Tercera columna: Posición del producto
                item.SubItems.Add(producto.Cantidad.ToString()); // Cuarta columna: Cantidad disponible
                item.Tag = producto;
                ProductosClienteListView.Items.Add(item);
            }

            // Ajustar automáticamente el ancho de las columnas
            foreach (ColumnHeader column in ProductosClienteListView.Columns)
            {
                column.Width = -2; // Ajusta el ancho de la columna al contenido y al encabezado
            }
        }


        private List<Producto> FiltrarProductosPorCliente(List<Producto> productos, int idCliente)
        {
            return productos.Where(p => p.IDCliente == idCliente).ToList();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ProductosClienteListView.SelectedItems.Count > 0)
            {
                var itemSeleccionado = ProductosClienteListView.SelectedItems[0];
                var producto = (Producto)itemSeleccionado.Tag;

                int cantidadSeleccionada = (int)numericUpDown1.Value;

                if (cantidadSeleccionada > 0 && cantidadSeleccionada <= producto.Cantidad)
                {
                    Producto productoSeleccionado = new Producto(producto.IDCliente, producto.Codigo, producto.Descripcion, producto.Posicion, cantidadSeleccionada);
                    productosSeleccionados.Add(productoSeleccionado);

                    ListViewItem item = new ListViewItem();
                    item.Text = producto.Codigo.ToString();
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Posicion);
                    item.SubItems.Add(cantidadSeleccionada.ToString());
                    item.Tag = productoSeleccionado;
                    ProductosSeleccionadosListView.Items.Add(item);

                    foreach (ColumnHeader column in ProductosSeleccionadosListView.Columns)
                    {
                        column.Width = -2;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una cantidad válida.");
                }
            }
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            if (ProductosSeleccionadosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, elija un producto seleccionado para quitar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemSeleccionado = ProductosSeleccionadosListView.SelectedItems[0];
            var producto = (Producto)itemSeleccionado.Tag;

            productosSeleccionados.Remove(producto);

            ProductosSeleccionadosListView.Items.Remove(itemSeleccionado);

            foreach (ColumnHeader column in ProductosSeleccionadosListView.Columns)
            {
                column.Width = -1;
            }
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar productos.", "Productos no seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TransportistaTextBox.Text))
            {
                MessageBox.Show("Por favor, introduzca un número de transportista válido.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres confirmar la orden con {productosSeleccionados.Count} productos?",
                "Confirmar Orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                MessageBox.Show("La orden ha sido confirmada correctamente.");
            }
            else
            {
                MessageBox.Show("La confirmación ha sido cancelada.");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay un IDCliente o IDOrden ingresado
            if (string.IsNullOrWhiteSpace(CuitTextBox.Text))
            {
                MessageBox.Show("No hay un CUIT de cliente ingresado para reiniciar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no se ha ingresado ningún ID
            }

            // Limpiar los TextBox donde se ingresaron los IDs
            CuitTextBox.Clear();

            // Limpiar el ListView antes de volver a cargar todas las órdenes
            ClientesListView.Items.Clear();

            // Cargar todas las órdenes de selección en el ListView
            CargarLista(); // Método que recarga todas las órdenes originales
        }
    }
}
