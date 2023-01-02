using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Interfaces
{
    public interface IListado
    {
        int IdMunicipio { get; set; }
        int IdMunicipioMulta { get; set; }
        int IdEmision { get; set; }
        int NumReq { get; set; }
        string RFC { get; set; }
        string TipoC { get; set; }
        string NumCtrl { get; set; }
        string RazonSocial { get; set; }
        string Localidad { get; set; }



    }
}
