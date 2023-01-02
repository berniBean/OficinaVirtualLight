using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class OficiosFactory
    {
        public const int RIF = 1;
        public const int PLUS = 2;


        public static obtenerOficiosSQL maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new OficiosDALRIF();
                case PLUS:
                    return new OficiosDALPLUS();
                default:
                    return null;
            }
        }
    }
}
