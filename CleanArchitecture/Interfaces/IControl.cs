using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IControl
    {
        int IdEmision { get; set; }
        string ClaveReferencia { get; set; }
        DateTime FechaEmision { get; set; }
        int Ejerciciofiscal { get; set; }
        string NombreEmision { get; set; }




    }
}
