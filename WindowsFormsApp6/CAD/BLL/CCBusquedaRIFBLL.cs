using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CCBusquedaRIFBLL
    {

        private CCBusquedaRIFDALPLUS bd = new CCBusquedaRIFDALPLUS();


        public ListaCBusquedaRIF GetListaBusquedaRIF(string dato)
        {
            ListaCBusquedaRIF listaReq = bd.GetListaBusquedaRIF(dato);
            return listaReq;

        }
    }
}
