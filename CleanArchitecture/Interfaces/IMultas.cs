using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IMultas : IDatoNotificaciones
    {
        string IdMultaRif { get; set; }
        string TIPO_MULTA { get; set; }
        double CTRL_MULTA { get; set; }
        DateTime FECHA_EMISION_MULTA { get; set; }
        DateTime FechaPago { get; set; }
        float Importe { get; set; }
        float Honorarios { get; set; }
        bool CumplioAntes { get; set; }
        DateTime FechaVencimiento { get; set; }
        string Ejecucion { get; set; }
        int IdHonorario { get; set; }

        //enlace controlMulta
        IControlMultas ControlMultas { get; set; }
        
        //colleccion honorarios
        ICollection<IHonorarios> HonorariosEnlace { get; set; }

    }
}
