using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IControlMultas : IControl
    {
        int Honorarios { get; set; }
        int Cantidad { get; set; }


    }
}
