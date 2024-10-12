using GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion;
using System;
using System.Collections.Generic;

namespace GrupoC.Tp3.CDU2
{
    public class GenerarOrdenDeSeleccionModel
    {
        // Definir una lista de órdenes de selección
        public List<OrdenesDeSeleccion> ListaOrdenesSeleccion { get; set; }

        // Definir una lista de órdenes de preparación
        public List<OrdenesDePreparacion> ListaOrdenesPreparacion { get; set; }

        // Constructor para inicializar las listas de órdenes
        public GenerarOrdenDeSeleccionModel()
        {
            // Inicializar la lista de órdenes de selección con datos ficticios
            ListaOrdenesSeleccion = new List<OrdenesDeSeleccion>
            {
                new OrdenesDeSeleccion(1002, 18, new DateTime(2024, 10, 12), "María López", "Alta"),
                new OrdenesDeSeleccion(1003, 22, new DateTime(2024, 10, 15), "Juan González", "Media"),
                new OrdenesDeSeleccion(1004, 35, new DateTime(2024, 10, 20), "Ana Torres", "Baja"),
                new OrdenesDeSeleccion(1005, 45, new DateTime(2024, 10, 25), "Pedro Martínez", "Media"),
                new OrdenesDeSeleccion(1006, 52, new DateTime(2024, 10, 28), "Carlos Pérez", "Alta"),
                new OrdenesDeSeleccion(1007, 33, new DateTime(2024, 10, 30), "María López", "Baja"),
                new OrdenesDeSeleccion(1008, 60, new DateTime(2024, 11, 01), "Juan González", "Media"),
                new OrdenesDeSeleccion(1009, 72, new DateTime(2024, 11, 03), "Ana Torres", "Alta"),
                new OrdenesDeSeleccion(1010, 85, new DateTime(2024, 11, 05), "Pedro Martínez", "Baja"),
                new OrdenesDeSeleccion(1011, 90, new DateTime(2024, 11, 07), "Laura Fernández", "Media")
            };

            // Inicializar la lista de órdenes de preparación con datos ficticios
            ListaOrdenesPreparacion = new List<OrdenesDePreparacion>
            {
                new OrdenesDePreparacion(18, 1002, "Producto A", 20, "1-2-3"),
                new OrdenesDePreparacion(22, 1003, "Producto B", 15, "2-3-4"),
                new OrdenesDePreparacion(35, 1004, "Producto C", 10, "3-4-5"),
                new OrdenesDePreparacion(45, 1005, "Producto D", 25, "4-5-6"),
                new OrdenesDePreparacion(52, 1006, "Producto E", 5, "5-6-7"),
                new OrdenesDePreparacion(33, 1007, "Producto F", 8, "6-7-8"),
                new OrdenesDePreparacion(60, 1008, "Producto G", 30, "7-8-9"),
                new OrdenesDePreparacion(72, 1009, "Producto H", 12, "8-9-1"),
                new OrdenesDePreparacion(85, 1010, "Producto I", 22, "9-1-2"),
                new OrdenesDePreparacion(90, 1011, "Producto J", 18, "1-2-3")
            };
        }
    }
}

