using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.structs
{
    class CargaNumOficios : AbstractProgress
    {
        private readonly ToolStripProgressBar _progressBar;
        private obtenerOficiosSQL _obtenerOficiosSQL;

        public CargaNumOficios(ToolStripProgressBar progressBar, obtenerOficiosSQL obtenerOficiosSQL)
        {
            _progressBar = progressBar;
            _obtenerOficiosSQL = obtenerOficiosSQL;
        }

        public async Task oficioModificador(IEnumerable<COficiosBO> consulta)
        {
            await procesoUpdate(consulta.ToList(),reportarProgreso);
        }
        private async Task procesoUpdate(List<COficiosBO> dataUpdate,IProgress<int> progress) 
        {
            int indice = 0;
            foreach (var item in dataUpdate)
            {
                indice++;
                var paso = new COficiosBO() {IdOficio = item.IdOficio, NumOficio = item.NumOficio, FechaRetro = item.FechaRetro };
                await _obtenerOficiosSQL.modificaNumOfico(paso);
                progress.Report(StaticPercentage.PercentageProgress(indice, dataUpdate.Count));
            }
            
        }

        public override void ReportarProgreso(int porcentaje)
        {
            _progressBar.Value = porcentaje;
        }
    }
}
