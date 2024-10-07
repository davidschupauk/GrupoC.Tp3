using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
using GrupoC.Tp3.CDU3.Mercaderia;

namespace GrupoC.Tp3.CDU3
{
    public partial class ConfirmarOrdenDeSeleccion : Form
    {
        private Ordenes ordenSeleccionada;
        private ConfirmarOrdenDeSeleccionModelo modelo = new();

        public ConfirmarOrdenDeSeleccion()
        {
            InitializeComponent();
        }
        private void confirmarOrdenDeSeleccionlistView_MouseClick(object sender, MouseEventArgs e)
        {
           

        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarOrdenDeSeleccion_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            confirmarOrdenDeSeleccionlistView.Items.Clear();

            foreach (var Orden in modelo.Ordenes)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = Orden.NroOrden.ToString();
                item.SubItems.Add(Orden.Cliente);
                item.SubItems.Add(Orden.Estado);
                item.Tag = Orden;
                confirmarOrdenDeSeleccionlistView.Items.Add(item);
            }
        }
        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una orden
            if (confirmarOrdenDeSeleccionlistView.SelectedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostrar un mensaje de error
                MessageBox.Show("Debe seleccionar una orden para generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }

             DetalleMercaderia detallemercaderiaForm = new DetalleMercaderia();

            // Mostrar el formulario2
            detallemercaderiaForm.Show();

        }

        private void confirmarOrdenDeSeleccionlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verificar si se hizo clic en un item
            if (confirmarOrdenDeSeleccionlistView.SelectedItems.Count > 0)
            {
                // Obtener el item seleccionado
                var itemSeleccionado = confirmarOrdenDeSeleccionlistView.SelectedItems[0];
               
            }
        }
    }
}
