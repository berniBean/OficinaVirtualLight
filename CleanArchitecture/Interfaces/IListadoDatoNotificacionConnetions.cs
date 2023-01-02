using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IListadoDatoNotificacionConnetions
    {
        //enlace municipio
        IMuncipio Municipio { get; set; }
        //coleccion datoNotificacion
        ICollection<IDatoNotificaciones> DatoNotificaciones { get; set; }
    }
}
