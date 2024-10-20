using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU6
{
    public class Despachos
    {
        public int CodProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }


    }

    public class Ordenes
    {
        public int NroOrden { get; set; }
        public string Cliente { get; set; }
      
    }
}
