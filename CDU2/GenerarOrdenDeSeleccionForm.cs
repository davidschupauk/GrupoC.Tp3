using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC.Tp3.CDU2
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
            FechaDateTimePicker.Format = DateTimePickerFormat.Custom;
            FechaDateTimePicker.CustomFormat = "dd/MM/yyyy"; // Formato personalizado
            FechaDateTimePicker.MinDate = DateTime.Today; // Establecer la fecha mínima a hoy
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            //Pendiente
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            //Pendiente
        }
    }
}
