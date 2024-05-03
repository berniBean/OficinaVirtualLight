using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerPDFSql
    {
        public abstract Task<ListPdfSql> listadoPDFSql(int idEmision);
        //public abstract Task<>
        public abstract Task<ListPdfSql> ListadoPdfFirmados(int idEmision);
        public abstract Task modificaEstatusPDf(pdfSQL pdfSQL);
        public abstract Task modificaEstatusMultaPDf(pdfSQL pdfSQL);

        public abstract Task<ListPdfSql> listadoPdfMultasSql(int idEmision);
        public abstract Task<ListPdfSql> listadoPdfMultasFirmadosSql(int idEmision);
        public abstract Task<ListPdfSql> listadoOficiosPDF(int idEmision, int idSup);
        public abstract Task<ListPdfSql> listadoOficiosMultasPDF(int idEmision, int idSup);
        public abstract Task<ListPdfSql> listadoRecibosMultasPDF(int idEmision, int idSup);



    }
}
