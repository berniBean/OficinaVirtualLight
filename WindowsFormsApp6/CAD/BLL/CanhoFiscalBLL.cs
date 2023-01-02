using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.DAL;

namespace WindowsFormsApp6.BLL
{
    class CanhoFiscalBLL
    {
        private CanhoFiscalDAL bd = new CanhoFiscalDAL();

        public ListCanhoFiscal GetCanho() {
            ListCanhoFiscal listAnho = bd.GetAnho();
            return listAnho;
        }
    }
}
