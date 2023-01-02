using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IFechaOficiosConnections
    {
        //Coleccion de controlOficios
        ICollection<IControlOficios> controlOficios { get; set; }
    }
}
