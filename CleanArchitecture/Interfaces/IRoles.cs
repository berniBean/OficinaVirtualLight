using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IRoles
    {
        int idRol { get; set; }
        int idUsuario { get; set; }
        string nombreRol { get; set; }
    }
}
