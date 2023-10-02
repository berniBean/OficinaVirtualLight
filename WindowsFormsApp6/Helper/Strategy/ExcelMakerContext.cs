using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.Helper.Strategy
{
    public class ExcelMakerContext<T>
    {
        private IStrategyExcel<T> _strategyExcel;

        public IStrategyExcel<T> StrategyExcel
        {
            set
            {
                _strategyExcel = value;
            }
        }

        public ExcelMakerContext( IStrategyExcel<T> strategyExcel)
        {
            _strategyExcel = strategyExcel;
        }

        public async Task RunStrategyExcel(List<T> listaRequerimientos, ExcelDataDto datos)
        {
            await _strategyExcel.MakeExcelAsync(listaRequerimientos, datos);
        }
    }
}
