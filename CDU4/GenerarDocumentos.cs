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
        public GenerarDocumentos()
        {
            InitializeComponent();
        }

        private void generarBoton_Click(object sender, EventArgs e)
        {
            if (pedidosPreparadosListView.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                ListViewItem selectedItem = pedidosPreparadosListView.SelectedItems[0];
                selectedItem.SubItems[4].Text = "Documentación Generada";
                MessageBox.Show($"Razón Social: Meme\n" +
                        $"Domicilio: Calle sin nombre\n" +
                        $"CUIT: 777\n" +
                        $"Remito: 1712\n" +
                        $"Fecha: Hoy\n" +
                        $"Total: Mucha guita",
                        "Información del Pedido");
                confirmarBoton.Enabled = true;
            }
            else
            {
                // No se seleccionó nada
                MessageBox.Show("Por favor selecciona un pedido primero.");
            }
        }
    }
}
