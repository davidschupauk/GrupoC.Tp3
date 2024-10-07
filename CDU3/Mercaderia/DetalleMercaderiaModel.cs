using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU3.Mercaderia
{
    internal class DetalleMercaderiaModel
    {
        public List<Mercaderias> Mercaderias { get; private set; } =
    [
        new Mercaderias { CodProducto = 22, Descripcion = "Product1", Cantidad = 22 },
        new Mercaderias { CodProducto = 25, Descripcion = "Product2", Cantidad = 50 },
        new Mercaderias { CodProducto = 29, Descripcion = "Product2", Cantidad = 10 },
        new Mercaderias { CodProducto = 30, Descripcion = "Product2", Cantidad = 35 },
    ];
    }
}
