using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerNombreBimestre
    {
        public abstract ListaCNombreBimestre ListNombreBimestre(string periodo, string OHE);

        public abstract ListaCNombreBimestre ListNombreBimestreInforme(string ahno, string periodo);
    }
}
