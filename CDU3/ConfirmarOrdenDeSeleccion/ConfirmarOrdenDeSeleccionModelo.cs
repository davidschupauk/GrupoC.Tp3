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
}