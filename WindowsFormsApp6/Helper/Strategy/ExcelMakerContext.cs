using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy
{
    public class ExcelMakerContext
    {
        private IStrategyExcel _strategyExcel;

        public IStrategyExcel StrategyExcel
        {
            set
            {
                _strategyExcel = value;
            }
        }

        public ExcelMakerContext( IStrategyExcel strategyExcel)
        {
            _strategyExcel = strategyExcel;
        }

        public async Task RunStrategyExcel(List<CListaRequeridosBO> listaRequerimientos, ExcelDataDto datos)
        {
            await _strategyExcel.MakeExcelAsync(listaRequerimientos, datos);
        }
    }
}
