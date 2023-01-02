using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.structs
{
    public interface IProgressAsync
    {
       Progress<int> reportarProgreso { get; set; }
       void ReportarProgreso(int porcentaje);
    }
}
