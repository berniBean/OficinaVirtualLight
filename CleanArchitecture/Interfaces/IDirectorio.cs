using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface  IDirectorio
    {
        int IdClaveOHE { get; set; }
        string Genero { get; set; }
        string Jefe { get; set; }
        string Domicilio { get; set; }
        string Cp { get; set; }



        

    }
}
