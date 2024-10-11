using GrupoC.Tp3.CDU3;
using GrupoC.Tp3.CDU4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU5
{
    public partial class ConsultarOrden : Form
    {
        private ConsultarOrdenModel modelo = new();

        public ConsultarOrden()
        {
            InitializeComponent();
        }

        private void listadoOrdenListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarOrden_Load(object sender, EventArgs e)
        {
            CargarLista(modelo.Ordenes);
        }

        private void CargarLista(List<Orden> ordenes)
        {
            listadoPedidosListView.Items.Clear();

            foreach (var orden in ordenes)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = orden.NroOrden.ToString();
                item.SubItems.Add(orden.Cliente);
                item.SubItems.Add(orden.Transportista);
                item.SubItems.Add(orden.Fecha.ToString());
                item.SubItems.Add(orden.Estado);
                item.Tag = orden;
                listadoPedidosListView.Items.Add(item);
            }
            foreach (ColumnHeader column in listadoPedidosListView.Columns)
            {
                column.Width = -2; // Ajusta el ancho de la columna al contenido
            }
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {

            List<Orden> ordenesFiltradas = new List<Orden>();

            if (!string.IsNullOrWhiteSpace(ordenTextBox.Text))
            {
                string ordenBuscada = ordenTextBox.Text.Trim();
                List<Orden> NroOrden = modelo.BuscarOrden(ordenBuscada);
                //CargarLista(NroOrden);
                ordenesFiltradas.AddRange(NroOrden);
            }

            // Verificar si se ingresó un nombre de cliente
            if (!string.IsNullOrWhiteSpace(ClienteTextBox.Text))
            {
                string clienteBuscado = ClienteTextBox.Text.Trim();
                List<Orden> cliente = modelo.BuscarCliente(clienteBuscado);
                //CargarLista(cliente);
                if (ordenesFiltradas.Count == 0)
                {
                    ordenesFiltradas.AddRange(cliente); // Si no se ha filtrado por orden, agregar resultados
                }
                else
                {
                    // Intersección entre las órdenes ya filtradas y las órdenes por cliente
                    ordenesFiltradas = ordenesFiltradas.Where(o => cliente.Any(c => c.NroOrden == o.NroOrden)).ToList();
                }
            }

            //TODO
            //El filtro de fecha por si solo no sirve, tiene que venir acompañado de una orden o cliente, rari
            DateTime fechaInicioDateTime = FechaInicioDateTimePicker.Value;
            DateTime fechaFinDateTime = FechaFinaldateTimePicker.Value;

            DateOnly fechaInicio = DateOnly.FromDateTime(fechaInicioDateTime);
            DateOnly fechaFin = DateOnly.FromDateTime(fechaFinDateTime);

            ordenesFiltradas = ordenesFiltradas.Where(o => o.Fecha >= fechaInicio && o.Fecha <= fechaFin).ToList();

            CargarLista(ordenesFiltradas);


            // Si ambos TextBox están vacíos, mostrar un mensaje opcional
            if (string.IsNullOrWhiteSpace(ordenTextBox.Text) && string.IsNullOrWhiteSpace(ClienteTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            listadoPedidosListView.Items.Clear();
            CargarLista(modelo.Ordenes);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void seleccioanarOrdenbutton_Click(object sender, EventArgs e)
        {
            if (listadoPedidosListView.SelectedItems.Count > 0)
            {
                listadoOrdenListView1.Items.Clear();
                ListViewItem selectedItem = listadoPedidosListView.SelectedItems[0];
                var ordenDetalleSeleccionado = modelo.OrdenDetalle.Where(orden => orden.NroOrden.ToString() == selectedItem.Text).ToList();

                
                    foreach (var orden in ordenDetalleSeleccionado)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = orden.CodigoProducto.ToString();
                        item.SubItems.Add(orden.NombreProducto);
                        item.SubItems.Add(orden.Cantidad.ToString());
                        item.SubItems.Add(orden.UbicacionDeposito);
                        item.Tag = orden;

                        listadoOrdenListView1.Items.Add(item);
                    }
            }
        }
    }
}
