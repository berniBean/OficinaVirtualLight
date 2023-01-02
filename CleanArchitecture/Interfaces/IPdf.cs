using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IPdf
    {
        string IdMultaRifPDF { get; set; }
        string Estatus { get; set; }
        int UrlFTP { get; set; }

        //Enlace Listado
        IListado Listado { get; set; }

    }
}
