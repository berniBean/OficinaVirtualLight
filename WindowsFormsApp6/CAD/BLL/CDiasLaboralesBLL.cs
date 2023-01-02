using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{

   

    class CDiasLaboralesBLL
    {
        private CDiaFeriadoDAL bd = new CDiaFeriadoDAL();

        public List<CdiasFeriadosBO> GetDiasFestivos() 
        {
            List<CdiasFeriadosBO> litDias = bd.GetDiasFestivos();
            return litDias;
        }

    }
}
