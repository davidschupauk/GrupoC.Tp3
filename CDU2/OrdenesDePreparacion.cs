using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU2
{
    public class OrdenesDePreparacion
    {
        public int IDCliente { get; }
        public int Codigo { get; }
        public string Producto { get; }
        public int Cantidad { get; }
        public string Ubicacion { get; }

        // Constructor
        public OrdenesDePreparacion(int idCliente, int codigo, string producto, int cantidad, string ubicacion)
        {
            IDCliente = idCliente;
            Codigo = codigo;
            Producto = producto;
            Cantidad = cantidad;
            Ubicacion = ubicacion;
        }
    }
}
