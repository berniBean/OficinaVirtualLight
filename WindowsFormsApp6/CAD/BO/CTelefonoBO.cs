using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CTelefonoBO : ITelefono
    {
        public int IdTelefono { get; set; }
        public string Telefono { get; set; }
    }
}
