using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoC.Tp3.CDU1.GenerarOrdenDePreparacion
{
    public class Clientes
    {
        public int Id { get; }
        public string Nombre { get; }
        public string CUIT { get; }
        public string Direccion { get; }
        public string Telefono { get; }
        public string Email { get; }

        //Constructor
        public Clientes(int id, string nombre, string cuit, string direccion, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            CUIT = cuit;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
    }
}
