using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Helper.Strategy
{
    public interface ICopyPaste<T>
    {
        Task CopiarPortaPapelesAsync(DataGridView dataGrid);

        Task PegarPortaPapelesAsync(IEnumerable<T> informacion, DataGridView dataGrid, MonthCalendar calendarioVacacional);
    }
}
