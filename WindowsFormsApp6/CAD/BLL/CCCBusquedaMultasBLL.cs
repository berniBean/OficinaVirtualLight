using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CCCBusquedaMultasBLL
    {

        private CCBusquedaMultasDAL bd = new CCBusquedaMultasDAL();

        public ListaCBusquedaMultas GetListaBusquedaMultasRIF(string dato)
        {
            ListaCBusquedaMultas listaMultas = bd.GetListaBusquedaMultasRIF(dato);
            return listaMultas;
        }


    }
}
