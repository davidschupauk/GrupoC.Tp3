using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion
{
    public class Producto
    {
        public int Codigo { get; }
        public string Descripcion { get; }
        public string Posicion { get; }
        public int Cantidad { get; }

        // Constructor
        public Producto(int codigo, string descripcion, string posicion, int cantidad)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Posicion = posicion;
            Cantidad = cantidad;
        }
    }
}
