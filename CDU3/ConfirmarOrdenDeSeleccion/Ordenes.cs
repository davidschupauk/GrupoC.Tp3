using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoC.Tp3.CDU3
{
    public class Ordenes
    {
        public int NroOrden { get; set; }
        public string Cliente { get; set; }
        public string FechaEntrega { get; set; }
        public string Estado { get; set; }

    }
    public class Mercaderias
    {
        public int CodProducto { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }

}