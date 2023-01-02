using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IDirecciones
    {
        string Rfc { get; set; }
        string Calle { get; set; }
        string Noext { get; set; }
        string NoInt { get; set; }
        string Colonia { get; set; }
        string Localidad { get; set; }
        string EntreCalles { get; set; }
        string CP { get; set; }
        string Municipio { get; set; }
    }
}
