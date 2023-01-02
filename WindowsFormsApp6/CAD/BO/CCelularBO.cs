using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CCelularBO : ICelular
    {
        public CCelularBO()
        {

        }
        public CCelularBO(int idCelular, string numeroCelular)
        {
            IdCelular = idCelular;
            NumeroCelular = numeroCelular;
        }

        public int IdCelular { get; set; }
        public string NumeroCelular { get; set; }
    }
}
