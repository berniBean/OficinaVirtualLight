using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    class IListadoControlConnections
    {

        //enlace municipio
        IMuncipio Municipio { get; set; }

        //coleccion controlplus
        ICollection<IControlRequerimientos> ControlRequerimientos { get; set; }



    }
}
