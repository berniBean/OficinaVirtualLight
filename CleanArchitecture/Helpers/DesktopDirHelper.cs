using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Helpers
{
    public static class DesktopDirHelper
    {
        public static string DireccionDef()
        {
            string s = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string ruta = s + "\\RIF";
            return ruta;
        }
    }
}
