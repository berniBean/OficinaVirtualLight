using CleanArchitecture.InterfacesUtilidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.Helper;
using WindowsFormsApp6.Helper.Strategy;
using WindowsFormsApp6.Helper.Strategy.Concretas;

namespace WindowsFormsApp6.structs
{
    public class ToExcelAsync :  IWriter<IEnumerable<CListaRequeridosBO>>
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly ToolStripStatusLabel _tsStatus;
        private readonly Label _lblProgress;
        private readonly ExcelDataDto _datos;      
        private ExcelMakerContext<CListaRequeridosBO> _contextExcel;
        

        public ToExcelAsync(ToolStripProgressBar progressBar, ToolStripStatusLabel tsStatus, Label lblProgress, ExcelDataDto datos, string tipo)
        {
            _progressBar = progressBar;
            _lblProgress = lblProgress;
            _datos = datos;
            _tsStatus = tsStatus;
            if (tipo.Equals("ListadoSinDatos"))            
                _contextExcel = new ExcelMakerContext<CListaRequeridosBO>(new SpreadRequerimientoSinDato(_progressBar, _tsStatus, _lblProgress));                           
            if (tipo.Equals("ListadoConDatos"))
                _contextExcel = new ExcelMakerContext<CListaRequeridosBO>(new ExcelListadoConDatos(_progressBar, _tsStatus, _lblProgress));
            if (tipo.Equals("MultasSinDatos"))
                _contextExcel = new ExcelMakerContext<CListaRequeridosBO>(new SpreadMultaSinDatos(_progressBar, _tsStatus, _lblProgress));
            if (tipo.Equals("MultasConDatos"))
                _contextExcel = new ExcelMakerContext<CListaRequeridosBO>(new ExcelMultasConDatos(_progressBar, _tsStatus, _lblProgress));
            if (tipo.Equals("Ejecucion"))
                _contextExcel = new ExcelMakerContext<CListaRequeridosBO>(new ExcelEjecucion(_progressBar, _tsStatus, _lblProgress));
        }


        public async Task WriterAsync(IEnumerable<CListaRequeridosBO> data)
        {
                
            await MakeExcelAsync(data.ToList());
        }

        private async Task MakeExcelAsync(List<CListaRequeridosBO> listaRequerimientos)
        {
            await _contextExcel.RunStrategyExcel(listaRequerimientos, _datos);

        }


    }
}
