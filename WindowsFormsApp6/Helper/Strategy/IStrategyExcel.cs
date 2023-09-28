


using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;


namespace WindowsFormsApp6.Helper.Strategy
{
    public interface IStrategyExcel 
    {
        Task MakeExcelAsync(IEnumerable<CListaRequeridosBO> listaRequerimientos, ExcelDataDto datos);
    }
}
