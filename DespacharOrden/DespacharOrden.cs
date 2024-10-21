using GrupoC.Tp3.CDU5;
using GrupoC.Tp3.CDU6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private int CodigoTransportistaActual;

        public Despachar()
        {
            InitializeComponent();
        }

        private void DespacharOrden_Load(object sender, EventArgs e)
        {
            datosTrasportistas.Items.Clear();
            ConfirmarDespachobutton.Enabled = false;
            ConfirmarTransportistabutton.Enabled = false;
        }

        private void CargarListaTransportista()
        {
            int dniValue;
            bool IsNumber = int.TryParse(dniTransportistatextBox.Text, out dniValue);
            datosTrasportistas.Items.Clear();

            foreach (var transportista in modelo2.Transportistas)
            {
                if (transportista.DNI == dniValue)
                {

                    ListViewItem item = new ListViewItem(transportista.CodTrasportista.ToString());
                    item.SubItems.Add(transportista.DNI.ToString());
                    item.SubItems.Add(transportista.Nombre);
                    item.SubItems.Add(transportista.Apellido);
                    item.Tag = transportista;

                    datosTrasportistas.Items.Add(item);
                    CodigoTransportistaActual = transportista.CodTrasportista;
                }
            }
            if (datosTrasportistas.Items.Count > 0)
            {
                datosTrasportistas.Items[0].Selected = true;
                ConfirmarTransportistabutton.Enabled = true;
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
        }

        private void ConfirmarTransportistabutton_Click(object sender, EventArgs e)
        {

            OrdenesPorDespacharlistView.Items.Clear();

            var despachosMostrar = modelo.Despachos.FindAll(t => t.CodTrasportista == CodigoTransportistaActual);
            foreach (var Despacho in despachosMostrar)
            {
                // Cargar a la lista si coincide
                ListViewItem item = new ListViewItem();
                item.Text = Despacho.NroOrden.ToString();
                item.SubItems.Add(Despacho.Cliente);
                item.SubItems.Add(Despacho.CodTrasportista.ToString());
                item.Tag = Despacho;
                OrdenesPorDespacharlistView.Items.Add(item);

            }
        }

        private void ConfirmarDespachobutton_Click(object sender, EventArgs e)
        {
            if (OrdenesPorDespacharlistView.SelectedItems.Count > 0)
            {
                var confirmacion = MessageBox.Show(
                    $"¿Estás seguro de que quieres confirmar el despacho de las ordenes seleccionadas?",
                    "Confirmar Despacho",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario selecciona 'Yes', confirmar la orden
                if (confirmacion == DialogResult.Yes)
                {
                    // Lógica para confirmar la orden
                    MessageBox.Show("Se ha realizado el despacho exitosamente");
                    foreach(ListViewItem item in OrdenesPorDespacharlistView.SelectedItems)
                    {
                        OrdenesPorDespacharlistView.Items.Remove(item);
                    }
                }
                else
                {
                    // Si el usuario selecciona 'No', no hacer nada
                    MessageBox.Show("La operación ha sido cancelada.");
                }
            }

        }

        private void cancelar_confirmacion_Click(object sender, EventArgs e)
        {
            OrdenesPorDespacharlistView.Items.Clear();
            datosTrasportistas.Items.Clear();

            CodigoTransportistaActual = -1;
        }

        private void buscarDniTransportistabutton_Click(object sender, EventArgs e)
        {
            CargarListaTransportista();
        }

        private void OrdenesPorDespacharlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfirmarDespachobutton.Enabled = OrdenesPorDespacharlistView.SelectedItems.Count > 0;
        }
    }
}
