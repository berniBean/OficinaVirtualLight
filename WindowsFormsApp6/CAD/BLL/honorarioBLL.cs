using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class honorarioBLL
    {
        private HonorariosDAL bd = new HonorariosDAL();

        public ListaHonorarios getHonorarios(int emision) 
        {
            ListaHonorarios listHonorario = bd.getHonorarios(emision);
            return listHonorario;
        }
    }
}
