using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerOHE
    {
        public abstract ListCoheActiva listadosOHE(string idSup, string periodo);
        public abstract ListCoheActiva ListadoNotificadoresOHE(string idSup);
    }
}
