using GrupoC.Tp3.CDU1.BuscarCliente;
using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU1
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        private GenerarOrdenDePreparacionModel model = new(); //creamos una instancia de la clase GenerarOrdenDePreparacionModel
        private List<Producto> productosSeleccionados = new(); // Lista de productos seleccionados
        public int Id { get; set; }

        private int nextId = 1; //Campo para llevar el conteo del ID

        private void ProductosClienteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductosClienteListView.SelectedItems.Count > 0)
            {
                // Habilitar el botón Agregar si hay un producto seleccionado
                AgregarButton.Enabled = true;
            }
            else
            {
                // Deshabilitar el botón Agregar si no hay nada seleccionado
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
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; // Formato personalizado
            dateTimePicker1.MinDate = DateTime.Today; // Establecer la fecha mínima a hoy
            numericUpDown1.Minimum = 0; // Valor mínimo
            numericUpDown1.Maximum = 10000; // Valor máximo
            numericUpDown1.Increment = 1; // Incremento de 1
            IDTextBox.Text = GenerateID().ToString();
            IDClienteTextBox.Text = Id.ToString(); // Asignar los valores a los controles cuando el formulario se carga

            // Cargar productos filtrados por IDCliente cuando se carga el formulario
            CargarListaProductos(Id);
        }

        // Método para generar un ID
        private int GenerateID()
        {
            return nextId++;
        }

        // Método para cargar la lista de productos filtrados por IDCliente
        private void CargarListaProductos(int idCliente)
        {
            // Filtrar productos por IDCliente usando el método que creamos previamente
            var productosFiltrados = FiltrarProductosPorCliente(model.ListaProductos, idCliente);

            // Limpiamos la lista antes de agregar nuevos elementos
            ProductosClienteListView.Items.Clear();

            // Cargar los productos filtrados en la ListView
            foreach (var producto in productosFiltrados)
            {
                ListViewItem item = new ListViewItem();
                item.Text = producto.IDCliente.ToString(); // Primera columna: ID del cliente
                item.SubItems.Add(producto.Codigo.ToString()); // Segunda columna: Código del producto
                item.SubItems.Add(producto.Descripcion); // Tercera columna: Descripción del producto
                item.SubItems.Add(producto.Posicion); // Cuarta columna: Posición del producto
                item.SubItems.Add(producto.Cantidad.ToString()); // Quinta columna: Cantidad disponible
                item.Tag = producto; // Asignamos el objeto Producto completo al Tag del ListViewItem
                ProductosClienteListView.Items.Add(item); // Agregamos el producto filtrado a 'ProductosClienteListView'
            }
        }

        // Método para filtrar productos por IDCliente
        private List<Producto> FiltrarProductosPorCliente(List<Producto> productos, int idCliente)
        {
            // Usamos LINQ para filtrar los productos según el IDCliente
            return productos.Where(p => p.IDCliente == idCliente).ToList();
        }

        // Botón para agregar el producto seleccionado a la lista de productos seleccionados
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ProductosClienteListView.SelectedItems.Count > 0)
            {
                // Obtener el producto seleccionado
                var itemSeleccionado = ProductosClienteListView.SelectedItems[0];
                var producto = (Producto)itemSeleccionado.Tag; // Obtenemos el objeto Producto

                // Obtener la cantidad seleccionada del NumericUpDown
                int cantidadSeleccionada = (int)numericUpDown1.Value;

                // Verificar que la cantidad seleccionada sea válida y no mayor a la cantidad disponible
                if (cantidadSeleccionada > 0 && cantidadSeleccionada <= producto.Cantidad)
                {
                    // Agregar el producto a la lista de productos seleccionados con la cantidad ajustada
                    Producto productoSeleccionado = new Producto(producto.IDCliente, producto.Codigo, producto.Descripcion, producto.Posicion, cantidadSeleccionada);
                    productosSeleccionados.Add(productoSeleccionado);

                    // Agregar el producto a la ListView de productos seleccionados
                    ListViewItem item = new ListViewItem();
                    item.Text = producto.Codigo.ToString();
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Posicion);
                    item.SubItems.Add(cantidadSeleccionada.ToString()); // Usar la cantidad seleccionada
                    item.Tag = productoSeleccionado; // Asignamos el objeto Producto completo al Tag del ListViewItem
                    ProductosSeleccionadosListView.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una cantidad válida.");
                }
            }
        }


        // Botón para quitar el producto seleccionado de la lista de productos seleccionados
        private void QuitarButton_Click(object sender, EventArgs e)
        {
            if (ProductosSeleccionadosListView.SelectedItems.Count > 0)
            {
                // Obtener el producto seleccionado
                var itemSeleccionado = ProductosSeleccionadosListView.SelectedItems[0];
                var producto = (Producto)itemSeleccionado.Tag; // Obtenemos el objeto Producto

                // Remover el producto de la lista de productos seleccionados
                productosSeleccionados.Remove(producto);

                // Remover el producto de la ListView de productos seleccionados
                ProductosSeleccionadosListView.Items.Remove(itemSeleccionado);
            }
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // Aquí puedes confirmar la orden con los productos seleccionados
            MessageBox.Show($"Se han seleccionado {productosSeleccionados.Count} productos.");
        }

        private void CancelarButton_Click(object sender, EventArgs e) // Botón cancelar y vuelve al menú
        {
            this.Close();
        }
    }
}
