using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy
{
    public class SaveDBContext
    {
        private IWriterAsync _writerAsync;

        public IWriterAsync writerAsync
        {
            set { _writerAsync = value; }
        }
        public SaveDBContext(IWriterAsync writerAsync)
        {
            _writerAsync = writerAsync;
        }

        public async Task RunStrategySaveDB(IEnumerable<CListaRequeridosBO> consulta)
        {
            await _writerAsync.SaveChangesAsync(consulta);
        }
    }
}
