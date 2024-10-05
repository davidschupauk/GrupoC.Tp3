using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU4
{
    internal class GenerarDocumentoModel
    {
    public List<Pedidos> ListaPedidos { get; private set; } =
    [
        new Pedidos { Orden = 160, Cliente = "Surf", Transportista = "David Schupauk", Fecha = new DateOnly(2024,12,13), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-2322", Domicilio = "Maturin 257", IdRemito = 777, Producto =  ["Teclado", "Mouse", "Monitor"], Cantidad = [3,2,1], FechaDocumento = DateTime.Now, Total = 150000  },
        new Pedidos { Orden = 784, Cliente = "EvilCorp", Transportista = "Juan Cuneo", Fecha = new DateOnly(2024,06,29), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-2322", Domicilio = "Maturin 257", IdRemito = 777, Producto = ["Teclado", "Mouse", "Monitor"], Cantidad = [3,2,1], FechaDocumento = DateTime.Now, Total = 150000  },
        new Pedidos { Orden = 257, Cliente = "Rappi", Transportista = "Tomas Lekerman", Fecha = new DateOnly(2024,02,01), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-2322", Domicilio = "Maturin 257", IdRemito = 777, Producto = ["Teclado", "Mouse", "Monitor"], Cantidad = [3,2,1], FechaDocumento = DateTime.Now, Total = 150000  },
    ];

    }
}
