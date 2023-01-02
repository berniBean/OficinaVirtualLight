using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IUsuario
    {
        int idUsuario { get; set; }
        string usuario { get; set; }
        string pass { get; set; }

        
    }
}
