using System.Data;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6.CAD.BLL
{
    class CCCBusquedaMasivaBLL
    {
        private CCBusquedaMasivaDAL bd = new CCBusquedaMasivaDAL();

        public void CrearListaBusquedaMasiva(string bo)
        {
            bd.CrearListaBusquedaMasiva(bo);
        }
    }
}
