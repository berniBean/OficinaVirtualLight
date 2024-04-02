using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class CopyPasteOficios : ICopyPaste<ListadoOficios>
    {
        public Task CopiarPortaPapelesAsync(DataGridView dataGrid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListadoOficios>> PegarPortaPapelesAsync(IEnumerable<ListadoOficios> informacion, DataGridView dataGrid, MonthCalendar calendarioVacacional)
        {
            throw new NotImplementedException();
        }
    }
}
