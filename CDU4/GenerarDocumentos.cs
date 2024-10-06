using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            CargarLista();
        }

        private void CargarLista()
        {
            pedidosPreparadosListView.Items.Clear();

            foreach (var Pedido in modelo.ListaPedidos)
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

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden Entregada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListViewItem selectedItem = pedidosPreparadosListView.SelectedItems[0];
            selectedItem.SubItems[4].Text = "Orden Entregada";
        }

        private void pedidosPreparadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedidosPreparadosListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = pedidosPreparadosListView.SelectedItems[0];
                if (selectedItem.SubItems[4].Text == "Documentación Generada")
                {
                    confirmarBoton.Enabled = true;
                    return;
                }
                if (selectedItem.SubItems[4].Text == "Preparado")
                {
                    confirmarBoton.Enabled = false;
                    return;
                }
                if (selectedItem.SubItems[4].Text == "Orden Entregada")
                {
                    generarBoton.Enabled = false;
                    return;

                }
            }
        }
    }
}
