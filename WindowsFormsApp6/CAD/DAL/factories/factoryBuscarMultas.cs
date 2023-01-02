using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    class factoryBuscarMultas
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerBusquedaMultas maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CCBusquedaMultasDAL();
                case PLUS:
                    return new CCBusquedaMultasDALPLUS();
                default:
                    return null;
            }
        }
    }
}
