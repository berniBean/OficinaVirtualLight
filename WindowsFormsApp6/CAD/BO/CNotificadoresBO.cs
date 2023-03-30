using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CNotificadoresBO
    {
        public CNotificadoresBO(string idNotificador, int idClaveOHE, string claveNotificador, string nombreNotificador)
        {
            IdNotificador = idNotificador;
            IdClaveOHE = idClaveOHE;
            ClaveNotificador = claveNotificador;
            NombreNotificador = nombreNotificador;
        }
        public CNotificadoresBO()
        {

        }

        public string IdNotificador { get; set; }
        public int IdClaveOHE { get; set; }
        public string ClaveNotificador { get; set; }
        public string NombreNotificador { get; set; }
    }
}
