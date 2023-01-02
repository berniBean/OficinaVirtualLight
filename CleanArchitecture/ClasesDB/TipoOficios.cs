using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClasesDB
{
    public class TipoOficios : ITipoOficios , ITipoOficiosConnections
    {
        public int IdTipo { get; set; }
        public string TipoOficio { get; set; }
        public ICollection<IControlOficios> contolOficios { get; set; }
    }
}
