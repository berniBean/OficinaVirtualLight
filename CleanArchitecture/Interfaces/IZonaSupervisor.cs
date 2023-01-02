using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IZonaSupervisor
    {
        
        int idSupervisor { get; set; }
        IUsuario supervisor { get; set; }
        int idZona { get; set; }
        IZona zona { get; set; }

    }
}
