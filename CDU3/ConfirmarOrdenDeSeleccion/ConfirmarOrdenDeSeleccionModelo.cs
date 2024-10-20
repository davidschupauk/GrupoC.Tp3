using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoC.Tp3.CDU3
{
    internal class ConfirmarOrdenDeSeleccionModelo
    {
        public List<Ordenes> Ordenes { get; private set; } =
    [
        new Ordenes { NroOrden = 102, Cliente = "Surf", FechaEntrega = "02-10-2024", Estado = "Pendiente de Procesar" },
        new Ordenes { NroOrden = 126, Cliente = "EvilCorp", FechaEntrega = "25-10-2024", Estado = "Pendiente de Procesar" },
        new Ordenes { NroOrden = 124, Cliente = "Rappi", FechaEntrega = "16-10-2024", Estado = "Pendiente de Procesar" },
        new Ordenes { NroOrden = 136, Cliente = "Rodo", FechaEntrega = "31-10-2024", Estado = "Pendiente de Procesar" },
    ];
    }
    internal class DetalleMercaderiaModel
    {
        public List<Mercaderias> Mercaderias { get; private set; } =
        [
        new Mercaderias { Ubicacion = "AAB", CodProducto = 22, Descripcion = "Zapatillas", Cantidad = 150 },
        new Mercaderias { Ubicacion = "ART", CodProducto = 22, Descripcion = "Zapatillas", Cantidad = 50 },
        new Mercaderias { Ubicacion = "AAZ", CodProducto = 25, Descripcion = "Remeras", Cantidad = 300 },
        new Mercaderias { Ubicacion = "ABT", CodProducto = 29, Descripcion = "Pantalones", Cantidad = 200 },
        new Mercaderias { Ubicacion = "ABS", CodProducto = 30, Descripcion = "Camisas", Cantidad = 300 },
    ];
    }
}