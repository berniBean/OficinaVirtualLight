using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerOficiosSQL
    {
        public abstract Task<ListCOficios> listadoOficiosSql(string idEmision);
        public abstract Task modificaNumOfico(COficiosBO oficios);

        public abstract Task<ListCOficios> listadoConcentradoOficioSql(string nombreEmision, int idEmision, int idSup);
        public abstract Task<ListCOficios> listadoConcentradoOficioMultasSql(string nombreEmision, int idEmision, int idSup);
    }
}
