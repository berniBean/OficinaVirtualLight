using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    //las fechas de oficios de las oficinas
    //y oficios se toman de fechas oficios
    public interface IDatoNotificaciones
    {
        string NumCtrl { get; set; }
        int Diligenica { get; set; }
        DateTime FechaNotificacion { get; set; }
        DateTime FechaCitatorio { get; set; }
        string Observaciones { get; set; }
        string Estatus { get; set; }
        string NombreNotificador { get; set; }



    }
}
