using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Helper.Strategy
{
    public interface ICopyPaste<T>
    {
        Task CopiarPortaPapelesAsync(DataGridView dataGrid);

        Task<List<T>> PegarPortaPapelesAsync(IEnumerable<T> informacion, DataGridView dataGrid, MonthCalendar calendarioVacacional);
    }
}
