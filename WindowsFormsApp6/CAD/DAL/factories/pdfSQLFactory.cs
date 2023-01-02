using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class pdfSQLFactory
    {
        public const int RIF = 1;
        public const int PLUS = 2;

        public static obtenerPDFSql maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new pdfSQLDALRIF();
                case PLUS:
                    return new pdfSQLDALPLUS();

                default:
                    return null;
            }
        }
    }
}
