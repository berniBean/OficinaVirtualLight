using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CConcentradoOficiosBO : COficiosBO
    {
        public CConcentradoOficiosBO() 
        {
                
        }

        public CConcentradoOficiosBO(string jefe, string domicilio, string cp, int total, int folioInicio, int folioFinal, int idOficio, string referencia, string zona, string oHE, int numOficio) : base( idOficio,  referencia,  zona,  oHE,  numOficio)
        {

            this.jefe = jefe;
            this.domicilio = domicilio;
            this.cp = cp;
            this.total = total;
            this.folioInicio = folioInicio;
            this.folioFinal = folioFinal;
        }

        public string jefe { get; set; }
        public string domicilio { get; set; }
        public string cp { get; set; }
        public int total { get; set; }
        public int folioInicio { get; set; }
        public int folioFinal { get; set; }
       
    }
}
