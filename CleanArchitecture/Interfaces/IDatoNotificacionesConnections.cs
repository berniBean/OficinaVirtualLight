using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IDatoNotificacionesConnections
    {
        //enlace listadoplus
        IListado Listado { get; set; }
    }
}
