using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    class CControlMultasBO
    {
        public int  Emision { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Ejercicio { get; set; }
        public string NombreEmision { get; set; }
        public int Honorarios { get; set; }
        public int CantidadMulta { get; set; }

        public CControlMultasBO()
        {

        }

        public CControlMultasBO(int emision, DateTime fechaEmision, int ejercicio, string nombreEmision, int honorarios , int cantidadMulta)
        {
            Emision = emision;
            FechaEmision = fechaEmision;
            Ejercicio = ejercicio;
            NombreEmision = nombreEmision;
            Honorarios = honorarios;
            CantidadMulta = cantidadMulta;
        }
    }
}
