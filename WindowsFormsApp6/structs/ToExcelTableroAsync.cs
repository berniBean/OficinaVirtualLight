using CleanArchitecture.InterfacesUtilidades;
using System;
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
    public class ToExcelTableroAsync : IWriter<IEnumerable<CTableroAdminBO>>
    {
        private readonly ToolStripLabel _tsStatus;
        private ExcelMakerContext<CTableroAdminBO> _contextExcelTablero;
        private readonly ExcelDataDto _datos;

        public ToExcelTableroAsync(ToolStripLabel tsStatus, ExcelDataDto datos, string tipo)
        {
            _datos = datos;
            _tsStatus = tsStatus;            
            if (tipo.Equals("InformePlus"))
                _contextExcelTablero = new ExcelMakerContext<CTableroAdminBO>(new ExcelInformeRequermiento(_tsStatus));
        }

        public  async Task WriterAsync(IEnumerable<CTableroAdminBO> data)
        {
            await MakeExcelAsync(data.ToList());
        }

        private async Task MakeExcelAsync(List<CTableroAdminBO> listaRequerimientos)
        {
            await _contextExcelTablero.RunStrategyExcel(listaRequerimientos, _datos);
        }
    }
}
