using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    class factoryNombreBimestre
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerNombreBimestre maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CCCNombreBimestreDAL();
                case PLUS:
                    return new CCCNombreBimestreDALPLUS();
                default:
                    return null;
            }
        }
    }
}
