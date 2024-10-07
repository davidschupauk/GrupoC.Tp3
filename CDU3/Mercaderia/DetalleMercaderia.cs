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

namespace GrupoC.Tp3.CDU3.Mercaderia
{
    public partial class DetalleMercaderia : Form
    {
        private DetalleMercaderiaModel modelo = new();
   

        public DetalleMercaderia()
        {
            InitializeComponent();
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarListaMercaderia()
        {
            list_detalle_mercaderia.Items.Clear();

            foreach (var mercaderia in modelo.Mercaderias)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = mercaderia.CodProducto.ToString();
                item.SubItems.Add(mercaderia.Descripcion);
                item.SubItems.Add(mercaderia.Cantidad.ToString());
                item.Tag = mercaderia;
                list_detalle_mercaderia.Items.Add(item);
            }
        }
        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de confirmación
            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres reservar los productos detallados?",
                "Confirmar Orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario selecciona 'Yes', confirmar la orden
            if (confirmacion == DialogResult.Yes)
            {
                // Lógica para confirmar la orden
                MessageBox.Show("Se han reservado los productos del inventario con exito");
                this.Close();
       
            }
            else
            {
                // Si el usuario selecciona 'No', no hacer nada
                MessageBox.Show("La reserva ha sido cancelada.");
                this.Close();
            }



        }
        private void DetalleMercaderia_Load(object sender, EventArgs e)
        {
            CargarListaMercaderia();
        }

     
    }
}
