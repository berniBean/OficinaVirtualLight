using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IControlOficiosConnections
    {
        //enlace oficina
        IOficinaHacienda oficinaHacienda { get; set; }
        //enlace fechaOficio
        IFechaOficios fechaOficio { get; set; }
        //enlace tipoOficio
        ITipoOficios tipoOficio { get; set; }
    }
}
