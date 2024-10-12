using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC.Tp3.CDU3.ConfirmarOrdenDeSeleccion
{
    internal class DetalleMercaderiaModel
    {
        public List<Mercaderias> Mercaderias { get; private set; } =
    [
        new Mercaderias { Ubicacion = AAB, CodProducto = 22, Descripcion = "Zapatillas", Cantidad = 22 },
        new Mercaderias { Ubicacion = ART, CodProducto = 22, Descripcion = "Zapatillas", Cantidad = 50 },
        new Mercaderias { Ubicacion = AAZ, CodProducto = 25, Descripcion = "Remeras", Cantidad = 50 },
        new Mercaderias { Ubicacion = ABT, CodProducto = 29, Descripcion = "Pantalones", Cantidad = 10 },
        new Mercaderias { Ubicacion = ABS, CodProducto = 30, Descripcion = "Camisas", Cantidad = 35 },
    ];
    }
}
