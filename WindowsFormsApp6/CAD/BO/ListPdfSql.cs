using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.BO
{
    public class ListPdfSql : BindingList<pdfSQL>
    {
        public static implicit operator ListPdfSql(obtenerPDFSql v)
        {
            throw new NotImplementedException();
        }
    }
}
