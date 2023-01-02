using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IHonorarios
    {
        int IdHonorarios { get; set; }
        float honorarios { get; set; }
        DateTime fechaAplicable { get; set; }
    }
}
