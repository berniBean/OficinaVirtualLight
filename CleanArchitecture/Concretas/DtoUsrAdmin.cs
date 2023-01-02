using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Concretas
{
    public class DtoUsrAdmin : IUsuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
    }
}
