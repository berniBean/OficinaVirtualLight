using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class ListCoheActivaBLL
    {
        private ClistaRequeridosDAL bd = new ClistaRequeridosDAL();

        public ListaClistaRequeridos GatReqGetRequerimientos(string periodo, string OHE) {
            ListaClistaRequeridos listaReq = bd.GetRequerimientos(periodo, OHE);
            return listaReq;
        }

        public ListaClistaRequeridos GetListaBusqueda(string periodo, string OHE, string dataBusqueda)
        {
            ListaClistaRequeridos listaReq = bd.GetListaBusqueda(periodo, OHE, dataBusqueda);
            return listaReq;
        }

        public ListaClistaRequeridos GetListaBusquedaMultasRIF(string periodo, string OHE, string dataBusqueda)
        {
            ListaClistaRequeridos listReq = bd.GetListaBusquedaMultasRIF(periodo, OHE, dataBusqueda);
            return listReq;
        }

        public ListaClistaRequeridos GetListadoEjecucionFiscal(string periodo, string OHE) 
        {
            ListaClistaRequeridos listReq = bd.GetListadoEjecucionFiscal(periodo, OHE);
            return listReq;
        }
        public ListaClistaRequeridos GetListaBusquedaMasiva(string periodo, string OHE)
        {
            ListaClistaRequeridos listaReq = bd.GetListaBusquedaMasiva(periodo, OHE);
            return listaReq;

        }

        public ListaClistaRequeridos GetListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta)
        {
            ListaClistaRequeridos listaReq = bd.GetListaBusquedaMasivaMULTAS(periodo, OHE, tipoMulta);
            return listaReq;
        }

        public ListaClistaRequeridos GetMultasRIFSup(string periodo, string OHE)
        {
            ListaClistaRequeridos listaReq = bd.GetMultasRIFSup(periodo, OHE);
            return listaReq;
        }
        public void ModificarObservacionesRIF(CListaRequeridosBO bo) {
            bd.ModificarObservacionesRIF(bo);
        }

        public void ModificaObservacionesMultasRIF(CListaRequeridosBO bo) 
        {
            bd.ModificaObservacionesMultasRIF(bo);
        }
        public void ModificarFechasRIF(CListaRequeridosBO bo) {
            bd.ModificarRequerimientosRIF(bo);
        }

        //modificar las multas RIF
        public void ModificaMultasRif(CListaRequeridosBO bo)
        {
            bd.ModificaMultasRif(bo);
        }

        public void ModificaEjecucion(CListaRequeridosBO bo)
        {
            bd.ModificaEjecucion(bo);
        }

        public void ModificaPagoMulta(CListaRequeridosBO bo)
        {
            bd.ModificaPagoMulta(bo);
        }
    }
}
