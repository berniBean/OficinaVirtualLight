using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CTableroAdminBLL
    {
        private CTableroAdminDAL bd = new CTableroAdminDAL();

        public async Task<CListaTableroAdmin> GetTablero(int año)
        {
            CListaTableroAdmin listTablero = await bd.GetTablero(año);
            return listTablero;
        }

        public CListaTableroAdmin GetGetTableroMultasSupervisor(int supervisor, int ejercicio) 
        {
            CListaTableroAdmin listaTablero = bd.GetTableroMultasSupervisor(supervisor, ejercicio);
            return listaTablero;
        }
    }
}
