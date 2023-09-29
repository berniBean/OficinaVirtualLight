using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy
{
    public interface IWriterAsync
    {
        Task SaveChangesAsync(IEnumerable<CListaRequeridosBO> consulta);
    }
}