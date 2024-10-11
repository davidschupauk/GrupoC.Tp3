using GrupoC.Tp3.CDU3;
using GrupoC.Tp3.CDU4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU5
{
    internal class ConsultarOrdenModel
    {
        public List<Orden> Ordenes { get; private set; } =
    [
        new Orden { NroOrden = 102, Cliente = "Surf", Transportista="Joaquin Sabina, DNI:2646120", Fecha = new DateOnly(2024,12,13), Estado = "Pendiente" },
        new Orden { NroOrden = 126, Cliente = "EvilCorp",Transportista="Charli Garcia, DNI:3254234", Fecha = new DateOnly(2024,12,23), Estado = "Pendiente" },
        new Orden { NroOrden = 124, Cliente = "Rappi", Transportista="Santiago Charpentier, DNI:56348658", Fecha = new DateOnly(2024,12,31), Estado = "Pendiente" },
        new Orden { NroOrden = 136, Cliente = "Rodo", Transportista="Leonel Ressi, DNI:55348658", Fecha = new DateOnly(2024,12,28), Estado = "Pendiente" },
    ];
        public List<ordenDetalle> OrdenDetalle { get; private set; } =
    [
        new ordenDetalle { NroOrden = 102, CodigoProducto = 23, NombreProducto ="Iphone 14 pro Max", Cantidad= 15, UbicacionDeposito="F=12,C=12,P=1233" },
        new ordenDetalle { NroOrden = 102, CodigoProducto = 24, NombreProducto = "MacBook Air M2", Cantidad = 10, UbicacionDeposito = "F=7,C=4,P=1055" },
        new ordenDetalle { NroOrden = 102, CodigoProducto = 65, NombreProducto = "AirPods Pro 2", Cantidad = 25, UbicacionDeposito = "F=3,C=9,P=1145" },
        new ordenDetalle { NroOrden = 126, CodigoProducto = 98, NombreProducto = "Samsung Galaxy S23", Cantidad = 20, UbicacionDeposito = "F=10,C=14,P=1250" },
        new ordenDetalle { NroOrden = 126, CodigoProducto = 10, NombreProducto = "Apple Watch Series 9", Cantidad = 12, UbicacionDeposito = "F=5,C=3,P=1133" },
        new ordenDetalle { NroOrden = 126, CodigoProducto = 22, NombreProducto = "iPad Pro 12.9", Cantidad = 8, UbicacionDeposito = "F=2,C=6,P=1121" },
        new ordenDetalle { NroOrden = 124, CodigoProducto = 71, NombreProducto = "Dell XPS 13", Cantidad = 5, UbicacionDeposito = "F=3,C=5,P=1010" },
        new ordenDetalle { NroOrden = 124, CodigoProducto = 11, NombreProducto = "HP Envy 15", Cantidad = 7, UbicacionDeposito = "F=1,C=2,P=1205" },
        new ordenDetalle { NroOrden = 124, CodigoProducto = 90, NombreProducto = "Logitech MX Master 3", Cantidad = 15, UbicacionDeposito = "F=9,C=8,P=1150" },
        new ordenDetalle { NroOrden = 136, CodigoProducto = 29, NombreProducto = "Sony WH-1000XM5", Cantidad = 10, UbicacionDeposito = "F=8,C=10,P=1175" },
        new ordenDetalle { NroOrden = 136, CodigoProducto = 44, NombreProducto = "Microsoft Surface Pro 9", Cantidad = 6, UbicacionDeposito = "F=7,C=9,P=1102" },
        new ordenDetalle { NroOrden = 136, CodigoProducto = 69, NombreProducto = "Google Pixel 7", Cantidad = 4, UbicacionDeposito = "F=4,C=7,P=1090" },

    ];

        public List<Orden> BuscarOrden(string Orden)
        {
            return (Ordenes.FindAll(o => o.NroOrden == Convert.ToInt32(Orden)));
        }
        public List<Orden> BuscarCliente(string Cliente)
        {
            return (Ordenes.FindAll(o => o.Cliente == Cliente));
        }
    }
}
