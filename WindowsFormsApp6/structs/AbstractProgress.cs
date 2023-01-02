using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.structs
{
    public abstract class AbstractProgress
    {
        public Progress<int> reportarProgreso;
        public AbstractProgress()
        {
            reportarProgreso= new Progress<int>(ReportarProgreso);
        }



        public abstract void ReportarProgreso(int porcentaje);
    }
}
