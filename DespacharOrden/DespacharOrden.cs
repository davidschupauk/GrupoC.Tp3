using GrupoC.Tp3.CDU5;
using GrupoC.Tp3.CDU6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC.Tp3.DespacharOrden
{
    public partial class Despachar : Form
    {
        private Despacho ordenSeleccionada;
        private Transportista transportistaSeleccionado;

        private DespacharOrdenDeSeleccionModelo modelo = new();
        private TransportistasModelo modelo2 = new();
        private ListViewItem selectedOrderItem;
        private ListViewItem ultimaOrdenAprobadaItem;

        public Despachar()
        {
            InitializeComponent();
        }

        private void DespacharOrden_Load(object sender, EventArgs e)
        {
            OrdenesDespachoAprobadolistView.Items.Clear();
            datosTrasportistas.Items.Clear();
            ConfirmarDespachobutton.Enabled = false;
            ConfirmarTransportistabutton.Enabled = false;
            CargarLista();
        }

        private void CargarLista()
        {
            OrdenesPorDespacharlistView.Items.Clear();

            foreach (var Despacho in modelo.Despachos)
            {
                // Cargar a la lista si coincide
                ListViewItem item = new ListViewItem();
                item.Text = Despacho.NroOrden.ToString();
                item.SubItems.Add(Despacho.Cliente);
                item.SubItems.Add(Despacho.Transportista);
                item.SubItems.Add(Despacho.CodTrasportista.ToString());
                item.Tag = Despacho;
                OrdenesPorDespacharlistView.Items.Add(item);

            }
        }

        private void CargarListaTransportista()
        {
            datosTrasportistas.Items.Clear();

            if (OrdenesPorDespacharlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una fila en la lista de órdenes antes de cargar transportistas.");
                return;
            }

            string codTransportista = OrdenesPorDespacharlistView.SelectedItems[0].SubItems[3].Text;

            if (!int.TryParse(codTransportista, out int codTransportistaInt))
            {
                MessageBox.Show("El valor de la orden seleccionada no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (var transportista in modelo2.Transportistas)
            {
                if (transportista.CodTrasportista == codTransportistaInt)
                {

                    ListViewItem item = new ListViewItem(transportista.CodTrasportista.ToString());
                    item.SubItems.Add(transportista.DNI.ToString());
                    item.SubItems.Add(transportista.Nombre);
                    item.SubItems.Add(transportista.Apellido);
                    item.Tag = transportista;

                    datosTrasportistas.Items.Add(item);
                }
            }
        }

        private void SeleccionarOrdenbutton_Click(object sender, EventArgs e)
        {

            if (OrdenesPorDespacharlistView.SelectedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar una orden para despachar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }
            selectedOrderItem = OrdenesPorDespacharlistView.SelectedItems[0];
            CargarListaTransportista();
            SeleccionarOrdenbutton.Enabled = false;
            ConfirmarTransportistabutton.Enabled = true;

        }

        private void ConfirmarTransportistabutton_Click(object sender, EventArgs e)
        {

            ListViewItem nuevoItem = new ListViewItem(selectedOrderItem.SubItems[0].Text);
            nuevoItem.SubItems.Add(selectedOrderItem.SubItems[1].Text);
            nuevoItem.SubItems.Add(selectedOrderItem.SubItems[2].Text);
            nuevoItem.SubItems.Add(selectedOrderItem.SubItems[3].Text);
            OrdenesDespachoAprobadolistView.Items.Add(nuevoItem);

            ultimaOrdenAprobadaItem = nuevoItem;
            OrdenesPorDespacharlistView.Items.Remove(selectedOrderItem);
            datosTrasportistas.Items.Clear();
            ConfirmarTransportistabutton.Enabled = false;
            ConfirmarDespachobutton.Enabled = true;
            selectedOrderItem = null;


        }

        private void ConfirmarDespachobutton_Click(object sender, EventArgs e)
        {
            if (ultimaOrdenAprobadaItem != null)
            {
         
                OrdenesDespachoAprobadolistView.Items.Remove(ultimaOrdenAprobadaItem);
                ultimaOrdenAprobadaItem = null;
                SeleccionarOrdenbutton.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay órdenes con transportistas confirmados para realizar el despacho.");
            }
        }
    }
}
