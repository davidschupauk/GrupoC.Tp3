using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC.Tp3.CDU4
{
    public partial class GenerarDocumentos : Form
    {

        private GenerarDocumentoModel modelo = new();

        public GenerarDocumentos()
        {
            InitializeComponent();
        }

        private void GenerarDocumentos_Load(object sender, EventArgs e)
        {
            pedidosPreparadosListView.Enabled = true;
            CargarLista(modelo.ListaPedidos);
        }

        private void CargarLista(List<Pedidos> pedidos)
        {
            pedidosPreparadosListView.Items.Clear();

            foreach (var Pedido in pedidos)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = Pedido.Orden.ToString();
                item.SubItems.Add(Pedido.Cliente);
                item.SubItems.Add(Pedido.Transportista);
                item.SubItems.Add(Pedido.Fecha.ToString());
                item.SubItems.Add(Pedido.Estado);
                item.Tag = Pedido;
                pedidosPreparadosListView.Items.Add(item);
            }
            foreach (ColumnHeader column in pedidosPreparadosListView.Columns)
            {
                column.Width = -2; // Ajusta el ancho de la columna al contenido
            }
        }

        private void generarBoton_Click(object sender, EventArgs e)
        {
            if (pedidosPreparadosListView.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                ListViewItem selectedItem = pedidosPreparadosListView.SelectedItems[0];
                if (selectedItem.SubItems[4].Text == "Preparado")
                {
                    selectedItem.SubItems[4].Text = "Documentación Generada";
                    Pedidos? pedidoseleccionado = modelo.ListaPedidos.Find(Pedido => Pedido.Orden.ToString() == selectedItem.Text);
                    if (pedidoseleccionado != null)
                    {
                        string productosInfo = "";
                        for (int i = 0; i < pedidoseleccionado.Producto.Length; i++)
                        {
                            productosInfo += $"Producto: {pedidoseleccionado.Producto[i]}, {pedidoseleccionado.Cantidad[i]} unidades\n";
                        }
                        MessageBox.Show(
                            $"Razón Social: {pedidoseleccionado.RazonSocial}\n" +
                            $"Domicilio: {pedidoseleccionado.Domicilio}\n" +
                            $"CUIT: {pedidoseleccionado.CUIT}\n" +
                            $"Remito: {pedidoseleccionado.IdRemito}\n" +
                            productosInfo +
                            $"Fecha Documento: {pedidoseleccionado.FechaDocumento.ToString()}\n" +
                            $"Total: {pedidoseleccionado.Total}",
                            "Información del Pedido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                }
                else
                {
                    MessageBox.Show("La documentacion de esta orden ya fue generada previamente", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // No se seleccionó nada
                MessageBox.Show("Por favor selecciona un pedido primero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }



        private void pedidosPreparadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedidosPreparadosListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = pedidosPreparadosListView.SelectedItems[0];

                if (selectedItem.SubItems[4].Text == "Orden Entregada")
                {
                    generarBoton.Enabled = false;
                    return;

                }
            }
        }


        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(OrdenTextBox.Text))
            {
                string ordenBuscada = OrdenTextBox.Text.Trim();
                List<Pedidos> NroOrden = modelo.BuscarOrden(ordenBuscada);
                CargarLista(NroOrden);
            }

            // Verificar si se ingresó un nombre de cliente
            if (!string.IsNullOrWhiteSpace(ClienteTextBox.Text))
            {
                string clienteBuscado = ClienteTextBox.Text.Trim();
                List<Pedidos> cliente = modelo.BuscarCliente(clienteBuscado);
                CargarLista(cliente);
            }

            // Si ambos TextBox están vacíos, mostrar un mensaje opcional
            if (string.IsNullOrWhiteSpace(OrdenTextBox.Text) && string.IsNullOrWhiteSpace(ClienteTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            pedidosPreparadosListView.Items.Clear();
            CargarLista(modelo.ListaPedidos);
        }

        private void label1_Click(object sender, EventArgs e) { } 
    }
}
