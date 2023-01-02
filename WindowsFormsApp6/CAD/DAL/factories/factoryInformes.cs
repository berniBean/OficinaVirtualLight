using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryInformes
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerInformes maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CCInformeAvanceDAL();
                case PLUS:
                    return new CCInformeAvanceDALPLUS();
                default:
                    return null;
            }
        }
    }
}
