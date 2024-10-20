using GrupoC.Tp3.CDU3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU6
{
    internal class ConfirmarEmpaquetadoModelo
    {
        public List<Despachos> Paquetes { get; private set; } =
    [
        new Despachos { CodProducto = 22, Descripcion = "Zapatillas", Cantidad = 300 },
        new Despachos { CodProducto = 25, Descripcion = "Remeras", Cantidad = 300 },
        new Despachos { CodProducto = 29, Descripcion = "Pantalones", Cantidad = 200 },
        new Despachos { CodProducto = 30, Descripcion = "Camisas", Cantidad = 300 }, 
        
    ];
    }

    internal class ConfirmarOrdenDeSeleccionModelo
    {
        public List<Ordenes> Ordenes { get; private set; } =
    [
        new Ordenes { NroOrden = 102, Cliente = "Surf" },
        new Ordenes { NroOrden = 126, Cliente = "Fravega" },
        new Ordenes { NroOrden = 124, Cliente = "Rappi" },
        new Ordenes { NroOrden = 136, Cliente = "Rodo" },
    ];
    }


}
