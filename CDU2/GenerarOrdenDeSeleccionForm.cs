using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
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

        // Método para generar un ID
        private int GenerateID()
        {
            return nextId++;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de confirmación
            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres generar la orden?",
                "Confirmar Orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario selecciona 'Yes', confirmar la orden
            if (confirmacion == DialogResult.Yes)
            {
                // Lógica para confirmar la orden
                MessageBox.Show("La orden ha sido generada correctamente.");
            }
            else
            {
                // Si el usuario selecciona 'No', no hacer nada
                MessageBox.Show("La confirmación ha sido cancelada.");
            }
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = FechaDateTimePicker.Value.Date; // Solo tomamos la fecha sin la hora

            // Limpiar el ListView antes de agregar los elementos filtrados
            ListadoOPListView.Items.Clear();

            // Filtrar la lista de órdenes según la fecha seleccionada
            var ordenesFiltradas = model.ListaOrdenesSeleccion
                .Where(orden => orden.Fecha.Date == fechaSeleccionada)
                .ToList();

            // Si se encuentran órdenes con la fecha seleccionada
            if (ordenesFiltradas.Any())
            {
                foreach (var orden in ordenesFiltradas)
                {
                    // Crear un nuevo ListViewItem para cada orden filtrada
                    ListViewItem item = new ListViewItem(orden.IDCliente.ToString());
                    item.SubItems.Add(orden.NumeroOrden.ToString());
                    item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(orden.Transportista);
                    item.SubItems.Add(orden.Estado);

                    // Añadir el item a ListadoOPListView
                    ListadoOPListView.Items.Add(item);
                }
            }
            else
            {
                // Si no se encuentran órdenes con la fecha seleccionada, mostrar un mensaje
                MessageBox.Show("No se encontraron órdenes con la fecha seleccionada.", "Filtrar Órdenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            IDOSTextBox.Text = GenerateID().ToString();
        }
    }
}
