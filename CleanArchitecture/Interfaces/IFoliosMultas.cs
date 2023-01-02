using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IFoliosMultas
    {
         int TotalMultas { get; set; }
         int TotalMEMultas { get; set; }
         int InicioME { get; set; }
         int FinalME { get; set; }
         int TotalMIMultas { get; set; }
         int InicioMI { get; set; }
         int FinalMI { get; set; }
    }
}
