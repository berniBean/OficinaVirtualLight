using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerRequeridos
    {
        public abstract void ObservacionesRequerimientos(CListaRequeridosBO bo);
        public abstract void ObservacionesMultas(CListaRequeridosBO bo);
        public abstract void EjecucionMulta(CListaRequeridosBO bo);
        public abstract void PagoMulta(CListaRequeridosBO bo);   
        public abstract void ModificarRequerimientos(CListaRequeridosBO bo);
        public abstract void ModificaMultas(CListaRequeridosBO bo);
        public abstract ListaClistaRequeridos ListaBusquedaMasiva(string periodo, string OHE);
        public abstract ListaClistaRequeridos ListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta);
        public abstract ListaClistaRequeridos ListaBusquedaMultasRIF(string periodo, string OHE, string dataBusqueda);
        public abstract ListaClistaRequeridos ListadoEjecucionFiscal(string periodo, string OHE);
        public abstract  ListaClistaRequeridos ListaBusqueda(string periodo, string OHE, string dataBusqueda);
        public abstract ListaClistaRequeridos MultasRIFSup(string periodo, string OHE);
        
        public abstract ListaClistaRequeridos Requerimientos(string periodo, string OHE);

    }
}
