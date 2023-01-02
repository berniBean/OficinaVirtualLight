using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClasesDB
{
    public class FechasOficios : IFechaOficios, IFechaOficiosConnections
    {
        public string IdEmision { get; set; }
        public DateTime FechaRetro { get; set; }
        public DateTime FechaOficios { get; set; }
        public ICollection<IControlOficios> controlOficios { get; set; }
    }
}
