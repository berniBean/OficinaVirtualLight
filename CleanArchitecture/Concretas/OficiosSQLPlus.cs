using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Concretas
{
    public class OficiosSQLPlus : IControlOficios,IFechaOficios, IOficinaHacienda, IZona
    {
        public int IdOficio { get; set; }
        public string IdEmision { get; set; }
        public int IdOHE { get; set; }
        public int IdTipoOficio { get; set; }
        public int NumOficio { get; set; }
        public string numGuia { get; set; }
        public DateTime FechaRetro { get; set; }
        public DateTime FechaOficios { get; set; }
        public int IdClaveOHE { get; set; }
        public int ZonaClave { get; set; }
        public string OHE { get; set; }
        public int ClaveZona { get; set; }
        public string Zona { get; set; }

        public OficiosSQLPlus(int _IdOficio, string _IdEmision, string _Zona, string _OHE, int _NumOficio )
        {
            IdOficio = _IdOficio;
            IdEmision = _IdEmision;
            Zona = _Zona;
            OHE = _OHE;
            NumOficio = _NumOficio;
        }
    }
}
