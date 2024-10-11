using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU5
{
    internal class Orden
    {
        public int NroOrden { get; set; }
        public string Cliente { get; set; }
        public string Estado { get; set; }
        public string Transportista { get; set; }
        public DateOnly Fecha { get; set; }

    }
}
