using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IZonaOficinaConnections
    {
        //coleccion oficinas
        ICollection<IOficinaHacienda> oficinaEnlace { get; set; }
    }
}
