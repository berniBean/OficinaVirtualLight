using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class StoreMultasAsync : AbstractProgress, IWriterAsync
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly Label _lblProgress;
        private readonly obtenerRequeridos _obReq;

        public StoreMultasAsync(ToolStripProgressBar progressBar, Label lblProgress, obtenerRequeridos obReq)
        {
            _progressBar = progressBar;
            _lblProgress = lblProgress;
            _obReq = obReq;
        }

        public async Task SaveChangesAsync(IEnumerable<CListaRequeridosBO> consulta)
        {
            await ProcesoGuardadoAsync(consulta.ToList(), reportarProgreso);
        }

        private async Task ProcesoGuardadoAsync(List<CListaRequeridosBO> listaClistaRequeridos, IProgress<int> progress = null)
        {


            var gato = (from item in listaClistaRequeridos
                        where (item.Estatus != "enviado")
                        select new CListaRequeridosBO()
                        {
                            _idMultaRif = item._idMultaRif,
                            Diligencia = item.Diligencia,
                            FechaNotificacion = item.FechaNotificacion,
                            FechaCitatorio = item.FechaCitatorio,
                            FechaPago = item.FechaPago,
                            Importe = item.Importe,
                            Honorarios = item.Honorarios,
                            CumplioAntes = item.CumplioAntes,
                            _fechaVencimiento = item._fechaVencimiento,
                            Estatus = item.Estatus,
                            Ejecucion = item.Ejecucion,
                           Observaciones = item.Observaciones,

                           

                        }).ToList();

            MessageBox.Show("Total documentos Actualizados:" + gato.Count);

            await _obReq.ModificaMultas(gato);

            MessageBox.Show("Guardado completado");

            progress.Report(0);
        }






        public override void ReportarProgreso(int porcentaje)
        {
            _progressBar.Value = porcentaje;

            if (porcentaje != 100 && porcentaje > 0)
            {
                _lblProgress.Text = string.Format("procesando...{0}% ", porcentaje);
            }
            else
            {
                _lblProgress.Text = "Listo.";
            }
        }


    }
}
