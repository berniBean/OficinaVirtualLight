using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CEmisionActualBLL
    {
        private CEmisionActualDAL bd = new CEmisionActualDAL();

        public ListCEmisionActual GetPeriodo(string anhoFiscal)
        {
            ListCEmisionActual listPeriodo = bd.GetPeriodo(anhoFiscal);
            return listPeriodo;
        }
    }
}

      