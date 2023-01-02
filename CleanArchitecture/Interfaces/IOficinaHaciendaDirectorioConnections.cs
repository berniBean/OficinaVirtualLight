using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IOficinaHaciendaDirectorioConnections
    {
        //enlace con directorio
        IDirectorio directorio { get; set; }
    }
}
