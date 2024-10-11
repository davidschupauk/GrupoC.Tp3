using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
using GrupoC.Tp3.CDU4;
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
            BuscarClienteForm buscarClienteForm = new BuscarClienteForm();
            if (buscarClienteForm.ShowDialog() == DialogResult.OK)
            {
               
                int clienteId = buscarClienteForm.ClienteSeleccionadoId;
                GenerarOrdenDePreparacionForm generarOrdenDePreparacionForm = new GenerarOrdenDePreparacionForm();
                generarOrdenDePreparacionForm.Id = clienteId;
                generarOrdenDePreparacionForm.ShowDialog();
            }
        }

        private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeSeleccionForm generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.Show();
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
    }
}
