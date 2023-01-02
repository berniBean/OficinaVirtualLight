using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IControlRequerimientos
    {
        DateTime fechaImpresion { get; set; }
        string detalleEmision { get; set; }
    }
}
