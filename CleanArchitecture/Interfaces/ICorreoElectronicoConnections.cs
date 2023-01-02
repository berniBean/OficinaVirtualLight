using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface ICorreoElectronicoConnections
    {
        ICollection<IDirCorreo> LinkDirCorreos { get; set; }
    }
}
