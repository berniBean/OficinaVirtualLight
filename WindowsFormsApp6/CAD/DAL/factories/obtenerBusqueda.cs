using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerBusqueda
    {
        public abstract ListaCBusquedaRIF ListaBusqueda(string dato);
    }
}
