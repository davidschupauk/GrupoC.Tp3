using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion
{
    public class GenerarOrdenDePreparacionModel
    {
        // Definir una lista de productos
        public List<Producto> ListaProductos { get; set; }

        // Constructor para inicializar la lista de productos
        public GenerarOrdenDePreparacionModel()
        {
            // Aquí puedes inicializar con algunos productos ficticios o cargar los productos desde otro lugar
            ListaProductos = new List<Producto>
            {
                new Producto(1, 1001, "Mouse Inalámbrico", "1-2-1", 50),
                new Producto(2, 1002, "Teclado Mecánico", "1-3-3", 20),
                new Producto(1, 1003, "Monitor 24 pulgadas", "2-1-1", 10),
                new Producto(3, 1004, "Laptop 15 pulgadas", "3-2-5", 8),
                new Producto(4, 1005, "Impresora Multifunción", "4-3-2", 5),
                new Producto(5, 1006, "Disco Duro Externo 1TB", "2-1-1", 15),
                new Producto(2, 1007, "Memoria USB 64GB", "3-2-2", 200),
                new Producto(3, 1008, "Auriculares Bluetooth", "2-3-3", 30),
                new Producto(1, 1009, "Cámara Web HD", "3-1-2", 25),
                new Producto(4, 1010, "Router WiFi", "1-1-1", 12)
            };
        }
    }
}
