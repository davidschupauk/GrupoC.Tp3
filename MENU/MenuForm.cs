using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
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

namespace GrupoC.Tp3.MENU
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void botonGenerarOrdenPreparacion_Click(object sender, EventArgs e)
        {
            GenerarOrdenDePreparacionForm generarOrdenDePreparacion = new GenerarOrdenDePreparacionForm();
            generarOrdenDePreparacion.Show();
        }

        private void botonGenerarDocumentos_Click(object sender, EventArgs e)
        {
            GenerarDocumentos generarDocumentos = new GenerarDocumentos();
            generarDocumentos.Show();
        }



        private void botonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar el modulo de preparación de ordenes!");
            Application.Exit();
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteForm buscarCliente = new BuscarClienteForm();
            buscarCliente.Show();
        }

        private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeSeleccionForm generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.Show();
        }
    }
}
