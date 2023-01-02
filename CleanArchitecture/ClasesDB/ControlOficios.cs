using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClasesDB
{
    class ControlOficios : IControlOficios, IControlOficiosConnections
    {
        public int IdOficio { get; set; }
        public string IdEmision { get; set; }
        public int IdOHE { get; set; }
        public int IdTipoOficio { get; set; }
        public int NumOficio { get; set; }
        public string numGuia { get; set; }
        public IOficinaHacienda oficinaHacienda { get; set; }
        public IFechaOficios fechaOficio { get; set; }
        public ITipoOficios tipoOficio { get; set; }
    }
}
