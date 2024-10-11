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
    }
}
