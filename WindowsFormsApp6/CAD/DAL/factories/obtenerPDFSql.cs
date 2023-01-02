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
        public abstract Task modificaEstatusPDf(pdfSQL pdfSQL);
        public abstract Task modificaEstatusMultaPDf(pdfSQL pdfSQL);

        public abstract Task<ListPdfSql> listadoPdfMultasSql(int idEmision);


    }
}
