using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU4
{
    internal class Pedidos
    {
        public int Orden { get; set; }
        public string Cliente { get; set; }
        public string Transportista { get; set; }
        public DateOnly Fecha { get; set; }
        public string Estado { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Domicilio { get; set; }
        public int IdRemito { get; set; }
        public string[] Producto { get; set; }
        public int[] Cantidad { get; set; }
        public DateTime FechaDocumento { get; set; }
        public int Total { get; set; }
    }
}
