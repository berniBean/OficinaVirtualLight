using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CdiasFeriadosBO
    {
        public  DateTime DiaFeriado { get; set; }

        CdiasFeriadosBO() { }

        public CdiasFeriadosBO(DateTime diaFeriado) 
        {
            DiaFeriado = diaFeriado;
        }
    }
}
