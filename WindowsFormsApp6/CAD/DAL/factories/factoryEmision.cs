using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryEmision
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerEmision maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CEmisionActualDAL();
                case PLUS:
                    return new CEmisionActualDALPLUs();
                default:
                    return null;
            }
        }
    }
}
