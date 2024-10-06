using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU2
{
    public class GenerarOrdenDeSeleccionModel
    {
        // Definir una lista de ordenes de selección
        public List<OrdenesDeSeleccion> ListaOrdenesSeleccion { get; set; }

        // Constructor para inicializar la lista de ordenes
        public GenerarOrdenDeSeleccionModel()
        {
            // Ordenes ficticias
            ListaOrdenesSeleccion = new List<OrdenesDeSeleccion>
                {
                    new OrdenesDeSeleccion(1001, 15, new DateTime(2023, 9, 10), "Carlos Pérez", "Pendiente"),
                    new OrdenesDeSeleccion(1002, 18, new DateTime(2023, 9, 12), "María López", "Procesando"),
                    new OrdenesDeSeleccion(1003, 22, new DateTime(2023, 9, 15), "Juan González", "Completada"),
                    new OrdenesDeSeleccion(1004, 35, new DateTime(2023, 9, 20), "Ana Torres", "Cancelada"),
                    new OrdenesDeSeleccion(1005, 45, new DateTime(2023, 9, 25), "Pedro Martínez", "Pendiente"),
                    new OrdenesDeSeleccion(1006, 52, new DateTime(2023, 9, 28), "Carlos Pérez", "Completada"),
                    new OrdenesDeSeleccion(1007, 33, new DateTime(2023, 9, 30), "María López", "Procesando"),
                    new OrdenesDeSeleccion(1008, 60, new DateTime(2023, 10, 01), "Juan González", "Pendiente"),
                    new OrdenesDeSeleccion(1009, 72, new DateTime(2023, 10, 03), "Ana Torres", "Cancelada"),
                    new OrdenesDeSeleccion(1010, 85, new DateTime(2023, 10, 05), "Pedro Martínez", "Completada")
                };
        }
    }
}
