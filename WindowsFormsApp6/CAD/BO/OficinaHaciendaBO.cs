using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class OficinaHaciendaBO : IOficinaHacienda, IOficinaHaciendaDirectorioConnections
    {
        public int IdClaveOHE { get; set;}
        public int ZonaClave { get; set;}
        public string OHE { get; set;}
        public IDirectorio directorio { get; set; }
    }
}
