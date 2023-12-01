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

        public async Task<List<CdiasFeriadosBO>> GetDiasFestivosAsync() 
        {
            List<CdiasFeriadosBO> litDias = await bd.GetDiasFestivos();
            return litDias;
        }

    }
}
