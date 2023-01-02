using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.DAL;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryYear
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerPeriodoFiscal maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CanhoFiscalDAL();
                case PLUS:
                    return new CanhoFiscalDALPLUS();

                default: 
                    return null;
            }
        }
    }
}
