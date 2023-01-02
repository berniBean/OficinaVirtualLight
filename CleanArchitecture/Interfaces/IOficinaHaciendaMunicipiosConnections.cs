using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IOficinaHaciendaMunicipiosConnections
    {
        //coleccion de municipios
        ICollection<IMuncipio> municipios { get; set; }
    }
}
