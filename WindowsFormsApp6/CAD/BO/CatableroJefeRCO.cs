using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CatableroJefeRCO
    {
        public int _emision { get; set; }
        public string _clave { get; set; }
        public int _ejercicio { get; set; }
        public string _detalleEmision { get; set; }

        public CatableroJefeRCO() { }

        public CatableroJefeRCO(int Emision, string Clave, int Ejercicio, string DetalleEmision) {
            _emision = Emision;
            _clave = Clave;
            _ejercicio = Ejercicio;
            _detalleEmision = DetalleEmision;
        }



    }
}
