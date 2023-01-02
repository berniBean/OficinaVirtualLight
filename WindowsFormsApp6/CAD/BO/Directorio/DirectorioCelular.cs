using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO.Directorio
{
    class DirectorioCelular : IDirCelular
    {
        public ICelular CelularAncla { get; set; }
        public IDirectorio DirectorioAncla { get; set; }
    }
}
