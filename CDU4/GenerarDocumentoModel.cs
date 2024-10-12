using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
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
        new Pedidos { Orden = 160, Cliente = "Surf", Transportista = "David Schupauk", Fecha = new DateOnly(2024,12,13), Estado = "Preparado", RazonSocial = "S.A", CUIT = "19-2528", Domicilio = "Maturin 257", IdRemito = 777, Producto =  ["Teclado", "Mouse", "Monitor"], Cantidad = [3,2,1], FechaDocumento = DateTime.Now, Total = 150000  },
        new Pedidos { Orden = 784, Cliente = "EvilCorp", Transportista = "Juan Cuneo", Fecha = new DateOnly(2024,06,29), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-4534", Domicilio = "Caracas 344", IdRemito = 324, Producto = ["Termo", "Conservadora", "Heladera"], Cantidad = [5,3,1], FechaDocumento = DateTime.Now, Total = 32000  },
        new Pedidos { Orden = 921, Cliente = "EvilCorp", Transportista = "Juan Cuneo", Fecha = new DateOnly(2024,06,29), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-4534", Domicilio = "Caracas 344", IdRemito = 324, Producto = ["Termo", "Conservadora", "Heladera"], Cantidad = [5,3,1], FechaDocumento = DateTime.Now, Total = 32000  },
        new Pedidos { Orden = 257, Cliente = "Rappi", Transportista = "Tomas Lekerman", Fecha = new DateOnly(2024,02,01), Estado = "Preparado", RazonSocial = "S.A", CUIT = "20-2322", Domicilio = "Monagas 121", IdRemito = 198, Producto = ["Caucho", "Resorte", "Retrovisor"], Cantidad = [8,9,2], FechaDocumento = DateTime.Now, Total = 43455  },
    ];

    public List<Pedidos> BuscarOrden(string Orden)
    {
        return (ListaPedidos.FindAll(o => o.Orden == Convert.ToInt32(Orden)));
    }
    public List<Pedidos> BuscarCliente(string Cliente)
    {
        return (ListaPedidos.FindAll(o => o.Cliente == Cliente));
    }

    }
}
