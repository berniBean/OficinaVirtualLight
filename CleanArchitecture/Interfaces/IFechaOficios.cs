using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IFechaOficios
    {
        string IdEmision { get; set; }
        DateTime FechaRetro { get; set; }
        DateTime FechaOficios { get; set; }


    }
}
