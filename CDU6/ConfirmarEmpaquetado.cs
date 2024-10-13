using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
using GrupoC.Tp3.CDU3;
using GrupoC.Tp3.CDU5;
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

namespace GrupoC.Tp3.CDU6
{
    public partial class Empaquetado : Form
    {
        private Ordenes ordenSeleccionada;
        private Despachos paqueteSeleccionada;
        private ConfirmarEmpaquetadoModelo modelo = new();
        private ConfirmarOrdenDeSeleccionModelo modelo2 = new();

        public Empaquetado()
        {
            InitializeComponent();
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empaquetado_Load(object sender, EventArgs e)
        {
            confirmar_empaquetado.Enabled = false;
            
            CargarLista();
        }

        private void CargarLista()
        {
            confirmarEmpaquetados.Items.Clear();

            foreach (var Orden in modelo2.Ordenes)
            {                
                // Cargar a la lista si coincide
                ListViewItem item = new ListViewItem();
                item.Text = Orden.NroOrden.ToString();
                item.SubItems.Add(Orden.Cliente);
                item.Tag = Orden;
                confirmarEmpaquetados.Items.Add(item);

            }
        }




        private void CargarDetalleLista()
        {
            detalle_productos.Items.Clear();

            foreach (var paquete in modelo.Paquetes)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = paquete.CodProducto.ToString();
                item.SubItems.Add(paquete.Descripcion);
                item.SubItems.Add(paquete.Cantidad.ToString());
                item.Tag = paquete;
                detalle_productos.Items.Add(item);
            }
        }


        private void MostrarDetalleButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una orden
            if (confirmarEmpaquetados.SelectedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar una orden para empaquetar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }

            CargarDetalleLista();
            confirmar_empaquetado.Enabled = true;
        }


        private void confirmarEmpaquetadoslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verificar si se hizo clic en un item
            if (confirmarEmpaquetados.SelectedItems.Count > 0)
            {
                // Obtener el item seleccionado
                var itemSeleccionado = confirmarEmpaquetados.SelectedItems[0];

            }
        }

        private void FiltraLista()
        {
            confirmarEmpaquetados.Items.Clear();

            int ordenId;
            bool isOrdenIdValid = int.TryParse(idOrden_textBox.Text, out ordenId); // Verifica que el valor de orden_id sea numérico

            foreach (var Orden in modelo2.Ordenes)
            {
                if (isOrdenIdValid && Orden.NroOrden == ordenId)
                { // Cargar a la lista si coincide
                    ListViewItem item = new ListViewItem();
                    item.Text = Orden.NroOrden.ToString();
                    item.SubItems.Add(Orden.Cliente);
                    item.Tag = Orden;
                    confirmarEmpaquetados.Items.Add(item);
                }
                    
             }

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            detalle_productos.Items.Clear();
            FiltraLista();

        }

        private void reiniciar_filtro_Click(object sender, EventArgs e)
        {
            idOrden_textBox.Text = string.Empty;
            detalle_productos.Items.Clear();
            CargarLista();
        }


        private void ConfirmarButton_Click(object sender, EventArgs e)
        {

            if (confirmarEmpaquetados.SelectedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar un producto para empaquetar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }

            // Mostrar el cuadro de confirmación
            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres confirmar el empaquetado de los productos detallados?",
                "Confirmar Empaquetado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario selecciona 'Yes', confirmar la orden
            if (confirmacion == DialogResult.Yes)
            {
                // Lógica para confirmar la orden
                MessageBox.Show("Se ha realizado la confirmacion del empaquetado");


            }
            else
            {
                // Si el usuario selecciona 'No', no hacer nada
                MessageBox.Show("La operación ha sido cancelada.");
            }

            confirmarEmpaquetados.SelectedItems[0].Remove();


        }

    }
}
