using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IMunicipioRequerimiento
    {

        int IdMunicipio { get; set; }
        //enlace municipio
        IMuncipio Municipio { get; set; }
        int IdEmision { get; set; }
        //enlace controlRequerimiento
        IControlRequerimientos ControlRequerimiento { get; set; }
    }
}
