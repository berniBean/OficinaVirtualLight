using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IDirCelular
    {
        ICelular CelularAncla { get; set; }
        IDirectorio DirectorioAncla { get; set; }
    }
}
