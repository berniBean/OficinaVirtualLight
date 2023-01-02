using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Concretas
{
    public class dtoFechas : IFechaOficios
    {
        public string IdEmision { get; set; }
        public DateTime FechaRetro { get; set; }
        public DateTime FechaOficios { get; set; }
        public dtoFechas()
        {

        }
        public dtoFechas(string idEmision, DateTime fechaRetro, DateTime fechaOficios)
        {
            IdEmision = idEmision;
            FechaRetro = fechaRetro;
            FechaOficios = fechaOficios;
        }
    }
}
