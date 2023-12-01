using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerRequeridos : AbstractProgress
    {
        public abstract Task ObservacionesRequerimientos(List<CListaRequeridosBO> bo);
        public abstract void ObservacionesMultas(CListaRequeridosBO bo);
        public abstract void EjecucionMulta(CListaRequeridosBO bo);
        public abstract void PagoMulta(CListaRequeridosBO bo);   
        public abstract Task ModificarRequerimientos(List<CListaRequeridosBO> bo);
        public abstract void ModificaMultas(CListaRequeridosBO bo);
        public abstract ListaClistaRequeridos ListaBusquedaMasiva(string periodo, string OHE);
        public abstract ListaClistaRequeridos ListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta);
        public abstract ListaClistaRequeridos ListaBusquedaMultasRIF(string periodo, string OHE, string dataBusqueda);
        public abstract ListaClistaRequeridos ListadoEjecucionFiscal(string periodo, string OHE);
        public abstract  ListaClistaRequeridos ListaBusqueda(string periodo, string OHE, string dataBusqueda);
        public abstract Task<ListaClistaRequeridos> MultasRIFSup(string periodo, string OHE);
        
        public abstract Task<ListaClistaRequeridos> Requerimientos(string periodo, string OHE);

    }
}
