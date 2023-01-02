using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IDirectorioConnections
    {
        //Collecion oficinas
        ICollection<IDirCelular> DirCelularsAncla { get; set; }
        ICollection<IDirCorreo> DirCorreosAncla { get; set; }
        ICollection<IDirTelefono> DirTelefonosAncla { get; set; }
        ICollection<IOficinaHacienda> Oficinas { get; set; }
    }
}
