using GrupoC.Tp3.CDU1;
using GrupoC.Tp3.CDU2;
using GrupoC.Tp3.CDU3;

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
                item.SubItems.Add(Orden.FechaEntrega);
                item.SubItems.Add(Orden.Estado);
                item.Tag = Orden;
                confirmarOrdenDeSeleccionlistView.Items.Add(item);
            }
        }

        private void CargarListaMercaderia()
        {
            list_detalle_mercaderia.Items.Clear();

            foreach (var mercaderia in modelo.Mercaderias)
            {
                //Cargar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = mercaderia.CodProducto.ToString();
                item.SubItems.Add(mercaderia.Ubicacion);
                item.SubItems.Add(mercaderia.Descripcion);
                item.SubItems.Add(mercaderia.Cantidad.ToString());
                item.Tag = mercaderia;
                list_detalle_mercaderia.Items.Add(item);
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

            CargarListaMercaderia();
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

        private void FiltraLista()
        {
            confirmarOrdenDeSeleccionlistView.Items.Clear();

            int ordenId;
            bool isOrdenIdValid = int.TryParse(orden_id.Text, out ordenId); // Verifica que el valor de orden_id sea numérico

            string clienteId = cliente_id.Text; // Obtén el valor del cliente_id

            foreach (var Orden in modelo.Ordenes)
            {

                if (isOrdenIdValid && Orden.NroOrden == ordenId && Orden.Cliente == clienteId)
                {
                    // Cargar a la lista si coincide
                    ListViewItem item = new ListViewItem();
                    item.Text = Orden.NroOrden.ToString();
                    item.SubItems.Add(Orden.Cliente);
                    item.SubItems.Add(Orden.Estado);
                    item.Tag = Orden;
                    confirmarOrdenDeSeleccionlistView.Items.Add(item);
                }
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            FiltraLista();

        }

        private void reiniciar_filtro_Click(object sender, EventArgs e)
        {
            cliente_id.Text = string.Empty;
            orden_id.Text = string.Empty;
            CargarLista();
        }
    }
}
