using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU2
{
    public class OrdenesDeSeleccion
    {
        public int NumeroOrden { get; set; } // Número de la orden de preparación
        public int IDCliente { get; set; } // Identificación del cliente
        public DateTime Fecha { get; set; } // Fecha de la orden (día, mes, año)
        public string Transportista { get; set; } // Nombre del transportista
        public string Prioridad { get; set; } // Prioridad de la orden
        public bool OrdenGenerada { get; set; } = false; // Campo para marcar si la orden fue generada

        // Constructor
        public OrdenesDeSeleccion(int numeroOrden, int idCliente, DateTime fecha, string transportista, string prioridad)
        {
            NumeroOrden = numeroOrden;
            IDCliente = idCliente;
            Fecha = fecha;
            Transportista = transportista;
            Prioridad = prioridad;
        }
    }

}
