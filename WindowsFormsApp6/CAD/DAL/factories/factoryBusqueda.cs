using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    class factoryBusqueda
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerBusqueda maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CCBusquedaRIFDAL();
                case PLUS:
                    return new CCBusquedaRIFDALPLUS();
                default:
                    return null;

            }
        }
    }
}
