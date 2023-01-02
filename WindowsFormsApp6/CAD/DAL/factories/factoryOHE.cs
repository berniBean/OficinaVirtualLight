using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryOHE
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerOHE maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CoheActivoDAL();
                case PLUS:
                    return new CoheActivoDALPLUS();
                default:
                    return null;
            }
        }
    }
}
