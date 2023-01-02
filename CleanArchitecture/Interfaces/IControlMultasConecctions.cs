using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    interface IControlMultasConecctions
    {
        //colleccion multas
        ICollection<IMultas> Multas { get; set; }
    }
}
