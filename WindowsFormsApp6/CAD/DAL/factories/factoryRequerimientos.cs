using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    class factoryRequerimientos
    {
        public const int RIF = 1;
        public const int PLUS = 2;


        public static obtenerRequeridos maker (int tipo, ToolStripProgressBar progressBar = null, Label lblProgress = null)
        {
            switch (tipo)
            {
                case RIF:
                    return new ClistaRequeridosDAL();
                case PLUS:
                    return new ClistaRequeridosDALPLUS(progressBar, lblProgress);
                default:
                    return null;
            }
        }
    }
}
