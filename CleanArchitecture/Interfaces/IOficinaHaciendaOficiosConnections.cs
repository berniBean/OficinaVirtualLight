using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IOficinaHaciendaOficiosConnections
    {
        //coleccion de oficios
        ICollection<IControlOficios> controlOficios { get; set; }
    }
}
