using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Helper.DataGridHelper;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class CopyPasteOficios : AbstractProgress, ICopyPaste<ListadoOficios>
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly ToolStripStatusLabel _tsStatus;
        private readonly Label _lblProgress;

        public CopyPasteOficios()
        {

        }

        public Task CopiarPortaPapelesAsync(DataGridView dataGrid)
        {
            throw new NotImplementedException();
        }

        public async Task PegarPortaPapelesAsync(IEnumerable<ListadoOficios> informacion, DataGridView dataGrid, MonthCalendar calendarioVacacional)
        {
            string texto_copiado = Clipboard.GetText();
            string[] lineas = texto_copiado.Split('\n');
            int error = 0;
            int fila = dataGrid.CurrentCell.RowIndex;
            int columna = dataGrid.CurrentCell.ColumnIndex;
            int tColumna;

            if (lineas.Length == 1 && GridHelper<ListadoOficios>.ColumnasArray(lineas, dataGrid, fila, columna, error))
                tColumna = GridHelper<ListadoOficios>.pegarUno(lineas, dataGrid, fila, columna, error);
            else
                tColumna = GridHelper<ListadoOficios>.pegado(lineas, dataGrid, calendarioVacacional, fila, columna, error);


        }

        public override void ReportarProgreso(int porcentaje)
        {
            throw new NotImplementedException();
        }


    }
}
