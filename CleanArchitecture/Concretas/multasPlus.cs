using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Concretas
{
    class multasPlus : IOficinaHacienda
    {
        public int IdClaveOHE { get; set; }
        public int ZonaClave { get; set; }
        public string OHE { get; set; }
        public IZona Zona { get; set; }
        public IDirectorio directorio { get; set; }
        public ICollection<IControlOficios> controlOficios { get; set; }
        public ICollection<IMuncipio> municipios { get; set; }
    }
}
