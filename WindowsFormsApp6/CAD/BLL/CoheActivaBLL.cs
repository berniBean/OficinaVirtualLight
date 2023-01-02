
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CoheActivaBLL
    {
        private CoheActivoDAL bd = new CoheActivoDAL();

        public ListCoheActiva GetOHE(string idSup, string periodo) {
            ListCoheActiva listOHe = bd.GetOHE(idSup, periodo);
            return listOHe;
        }





    }
}
