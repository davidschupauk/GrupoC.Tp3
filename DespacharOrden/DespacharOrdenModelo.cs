using GrupoC.Tp3.CDU3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC.Tp3.CDU6
{
    internal class TransportistasModelo
    {
        public List<Transportista> Transportistas { get; private set; } =
    [
        new Transportista { CodTrasportista = 55, DNI = 35666897, Nombre = "Juan Pablo", Apellido = "Cuneo"},
        new Transportista { CodTrasportista = 102, DNI = 40987519, Nombre = "Tadeo", Apellido = "Zamora"},
        new Transportista { CodTrasportista = 25, DNI = 39568878, Nombre = "Martin", Apellido = "Martinez"},
        new Transportista { CodTrasportista = 3, DNI = 41567826,  Nombre = "Pablo" , Apellido = "Gonzalez"}, 
        
    ];
    }

    internal class DespacharOrdenDeSeleccionModelo
    {
        public List<Despacho> Despachos { get; private set; } =
    [
        new Despacho { NroOrden = 102, Cliente = "Surf", CodTrasportista = 55   },
        new Despacho { NroOrden = 126, Cliente = "Fravega", CodTrasportista = 102 },
        new Despacho { NroOrden = 25, Cliente = "Fravega", CodTrasportista = 102 },
        new Despacho { NroOrden = 124, Cliente = "Rappi" , CodTrasportista = 25  },
        new Despacho { NroOrden = 136, Cliente = "Rodo" , CodTrasportista = 3  },
    ];
    }


}
