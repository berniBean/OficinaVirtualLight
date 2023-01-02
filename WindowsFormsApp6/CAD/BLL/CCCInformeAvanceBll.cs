using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CCCInformeAvanceBll
    {
        private CCInformeAvanceDAL bd = new CCInformeAvanceDAL();

        public ListaInformeAvance getAvancesRIF(int emision, int supervisor)
        {
            ListaInformeAvance listAvance = bd.GetAvancesRIF(emision,supervisor);
            return listAvance;
        }

        public ListaInformeAvance GetAvanceAdmin(int emision) 
        {
            ListaInformeAvance listAvance = bd.GetAvanceAdmin(emision);
            return listAvance;
        }

        public ListaInformeAvance GetAvanceMultaSup(int emision, int supervisor)
        {
            ListaInformeAvance listAvance = bd.GetAvanceMultaSup(emision, supervisor);
            return listAvance;
        }
    }
}
