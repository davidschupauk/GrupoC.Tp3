namespace GrupoC.Tp3.CDU3
{
    internal class ConfirmarOrdenDeSeleccionModelo
    {
        public List<Ordenes> Ordenes { get; private set; } =
    [
        new Ordenes { NroOrden = 102, Cliente = "Surf", Estado = "Pendiente" },
        new Ordenes { NroOrden = 126, Cliente = "EvilCorp", Estado = "Pendiente" },
        new Ordenes { NroOrden = 124, Cliente = "Rappi", Estado = "Pendiente" },
        new Ordenes { NroOrden = 136, Cliente = "Rodo", Estado = "Pendiente" },
    ];
    }
}