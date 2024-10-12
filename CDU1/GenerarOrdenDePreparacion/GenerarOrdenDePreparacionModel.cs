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
            // Productos ficticios
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

        public List<Clientes> ListaClientes { get; private set; } =
[
            new Clientes(1, "Empresa ABC S.A.", "30-12345678-1", "Calle Falsa 123", "555-1111", "contacto@empresaabc.com"),
            new Clientes(2, "Industria XYZ S.R.L.", "30-23456789-2", "Av. Principal 456", "555-2222", "info@industriaxyz.com"),
            new Clientes(3, "Comercializadora Pérez Hnos.", "30-34567890-3", "Pje. Secundario 789", "555-3333", "ventas@perezhnos.com"),
            new Clientes(4, "Distribuidora Fernández S.A.", "30-45678901-4", "Calle Luna 101", "555-4444", "logistica@fernandezsa.com"),
            new Clientes(5, "Transportes Sánchez S.R.L.", "30-56789012-5", "Av. Libertad 202", "555-5555", "contacto@transportessanchez.com"),
            new Clientes(6, "Inversiones Díaz S.A.", "30-67890123-6", "Calle Sol 303", "555-6666", "info@inversionesdiaz.com"),
            new Clientes(7, "Constructora Ramírez S.R.L.", "30-78901234-7", "Av. Los Olmos 404", "555-7777", "contacto@constructoraramirez.com"),
            new Clientes(8, "Agropecuaria Morales S.A.", "30-89012345-8", "Calle Verde 505", "555-8888", "ventas@agromorales.com"),
            new Clientes(9, "Automotriz López S.A.", "30-90123456-9", "Pje. Azul 606", "555-9999", "info@automotrizlopez.com"),
            new Clientes(10, "Minería Martínez S.A.", "30-01234567-0", "Av. Roca 707", "555-1010", "contacto@mineriamartinez.com")
];

        public bool IsValidCuit(string cuit)
        {
            return cuit.Length == 13; // Metodo para evaluar la longitud del CUIT
        }
        public Clientes BuscarClientePorCuit(string cuit)
        {
            return ListaClientes.FirstOrDefault(c => c.CUIT == cuit);
        }
    }
}
