using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU6
{
    public class Transportista
    {
        public int CodTrasportista { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    

    }

    public class Despacho
    {
        public int NroOrden { get; set; }
        public string Cliente { get; set; }
        public int CodTrasportista { get; set; }

    }
}
