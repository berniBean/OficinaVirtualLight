using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IFoliosRequerimientos
    {
         int Total { get; set; }
         int FolioInicio { get; set; }
         int FolioFinal { get; set; }
    }
}
