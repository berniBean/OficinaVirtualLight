using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IListadoPdfConnections
    {
        //enlace municipio
        IMuncipio Municipio { get; set; }
        //coleccion pdfs
        ICollection<IPdf> Pdfs { get; set; }
    }
}
