﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryMasiva
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerBusquedaMasiva maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CCBusquedaMasivaDAL();
                case PLUS:
                    return new CCBusquedaMasivaDALPLUS();
                default:
                    return null;
            }
        }
    }
}
