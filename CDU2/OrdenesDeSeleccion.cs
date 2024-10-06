using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU2
{
    public class OrdenesDeSeleccion
    {
        public int NumeroOrden { get; set; } // Número de la orden
        public int IDCliente { get; set; } // Identificación del cliente
        public DateTime Fecha { get; set; } // Fecha de la orden (día, mes, año)
        public string Transportista { get; set; } // Nombre del transportista
        public string Estado { get; set; } // Estado de la orden

        // Constructor
        public OrdenesDeSeleccion(int numeroOrden, int idCliente, DateTime fecha, string transportista, string estado)
        {
            NumeroOrden = numeroOrden;
            IDCliente = idCliente;
            Fecha = fecha;
            Transportista = transportista;
            Estado = estado;
        }
    }

}
