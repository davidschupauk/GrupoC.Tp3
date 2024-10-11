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
        private GenerarOrdenDePreparacionModel model = new();
        private List<Producto> productosSeleccionados = new();
        public int Id { get; set; }

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
            IDClienteTextBox.Text = Id.ToString();

            CargarListaProductos(Id);
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
                column.Width = -1; // Ajusta el ancho de la columna al contenido y al encabezado
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
                        column.Width = -1;
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
    }
}
