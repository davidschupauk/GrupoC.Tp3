using GrupoC.Tp3.CDU1.BuscarCliente;
using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC.Tp3.CDU1
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        private GenerarOrdenDePreparacionModel model = new(); //creamos una instancia de la clase GenerarOrdenDePreparacionModel
        public int Id { get; set; }

        private int nextId = 1; //Campo para llevar el conteo del ID
        public GenerarOrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; // Formato personalizado
            dateTimePicker1.MinDate = DateTime.Today; // Establecer la fecha mínima a hoy
            numericUpDown1.Minimum = 0; // Valor mínimo
            numericUpDown1.Maximum = 10000; // Valor máximo
            numericUpDown1.Increment = 1; // Incremento de 1
            IDTextBox.Text = GenerateID().ToString();
            IDClienteTextBox.Text = Id.ToString(); // Asignar los valores a los controles cuando el formulario se carga
        }
        private int GenerateID()
        {
            return nextId++;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            //completar
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            //completar
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            //completar
        }

        private void CancelarButton_Click(object sender, EventArgs e) //boton cancelar y vuelve al menú
        {
            this.Close();
        }
    }
}
