using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IMuncipio
    {
        int idMunicipio { get; set; }
        int OHEClave { get; set; }
        string muncipio { get; set; }

        //enlcace con oficina
        IOficinaHacienda OficinaHacienda { get; set; }

        //collecion listados
        ICollection<IListado> listados { get; set; }
        //colleccion municipiosRequerimientos
        ICollection<IMunicipioRequerimiento> municipioRequerimientos { get; set; }


    }
}
