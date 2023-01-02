using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IControlOficios
    {
        int IdOficio { get; set; }
        string IdEmision { get; set; }
        int IdOHE { get; set; }
        int IdTipoOficio { get; set; }
        int NumOficio { get; set; }
        string numGuia { get; set; }



    }
}
