using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CCNombreBimestreBLL
    {
        private CCCNombreBimestreDAL bd = new CCCNombreBimestreDAL();


        public ListaCNombreBimestre GetNombreEmisionInforme(string ahno, string periodo) {

            ListaCNombreBimestre nombreEmision = bd.GetNombreEmisionInforme(ahno, periodo);
            return nombreEmision;
        }
        public ListaCNombreBimestre GetNombreEmision(string idSup, string periodo)
        {
            ListaCNombreBimestre nombreEmision = bd.GetNombreEmision(idSup, periodo);
            return nombreEmision;
        }

    }
}
