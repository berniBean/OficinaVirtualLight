using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IOficinaHacienda
    {
        int IdClaveOHE { get; set; }
        int ZonaClave { get; set; }
        string OHE { get; set; }


    }
}
