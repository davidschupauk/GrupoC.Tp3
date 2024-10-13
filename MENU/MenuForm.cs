using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
using GrupoC.Tp3.CDU3;
using GrupoC.Tp3.CDU4;
using GrupoC.Tp3.CDU5;
using GrupoC.Tp3.CDU6;
using System;
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

        private void botonGenerarOrdenDePreparacion_Click(object sender, EventArgs e)
        {
            GenerarOrdenDePreparacionForm generarOrdenDePreparacionForm = new GenerarOrdenDePreparacionForm();
            generarOrdenDePreparacionForm.Show();
            
        }

        private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeSeleccionForm generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.Show();
        }

        private void botonConfirmarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenDeSeleccion confirmarOrdenDeSeleccion = new ConfirmarOrdenDeSeleccion();
            confirmarOrdenDeSeleccion.Show();
        }


        private void botonGenerarDocumentos_Click(object sender, EventArgs e)
        {
            GenerarDocumentos generarDocumentos = new GenerarDocumentos();
            generarDocumentos.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar el módulo de preparación de órdenes!");
            Application.Exit();
        }


        private void ConfirmarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenDeSeleccion confirmarOrdendeSeleccion = new ConfirmarOrdenDeSeleccion();
            confirmarOrdendeSeleccion.Show();
        }

        private void consultarOrdenButton_Click(object sender, EventArgs e)
        {
            ConsultarOrden consultarOrden = new ConsultarOrden();
            consultarOrden.Show();
        }
    }
}
