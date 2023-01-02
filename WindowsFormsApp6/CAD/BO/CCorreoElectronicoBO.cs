using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CCorreoElectronicoBO : ICorreoElectronico
    {
        public CCorreoElectronicoBO(int idCorreoElectronico, string correo)
        {
            IdCorreoElectronico = idCorreoElectronico;
            Correo = correo;
        }

        public int IdCorreoElectronico { get; set; }
        public string Correo { get; set; }
    }
}
