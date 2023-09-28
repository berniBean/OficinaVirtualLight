using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.structs
{
    class ActualizaBDAsync : AbstractProgress
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly Label _lblProgress;
        private readonly obtenerRequeridos _obReq;
        private readonly string _tipoDato;


        public ActualizaBDAsync(ToolStripProgressBar progressBar, Label lblProgress, string tipoDato, obtenerRequeridos obReq = null)
        {
            _progressBar = progressBar;
            _lblProgress = lblProgress;
            _obReq = obReq;
            _tipoDato = tipoDato;
        }

        public async Task GuardarAsync(IEnumerable<CListaRequeridosBO> consulta)
        {
            await ProcesoGuardadoAsync(consulta.ToList(), reportarProgreso);
        }

        private async Task ProcesoGuardadoAsync(List<CListaRequeridosBO> listaClistaRequeridos, IProgress<int> progress = null)
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();
            var total = listaClistaRequeridos.Count();
            var i = 0;


            var gato = (from item in listaClistaRequeridos
                        where (item.Modificado && item.Estatus != "enviado") || (item.ModificaObservacion || item.ModificaMalCapturado || item.ModificaNombreNotificador)
                        select new CListaRequeridosBO()
                        {
                            Diligencia = item.Diligencia,
                            FechaNotificacion = item.FechaNotificacion,
                            FechaCitatorio = item.FechaCitatorio,
                            OficioSEFIPLAN = item.OficioSEFIPLAN,
                            FechaEnvioSefiplan = item.FechaEnvioSefiplan,
                            NumCtrl = item.NumCtrl,
                            Estatus = item.Estatus,
                            Observaciones = item.Observaciones,
                            NotasObservaciones = item.NotasObservaciones,
                            ActaNotificacion = item.ActaNotificacion,
                            ActaCitatorio = item.ActaCitatorio,
                            NotificacionCitatorio = item.NotificacionCitatorio,
                            NombreNotificador = item.NombreNotificador
                        }).ToList();

            await Task.Run(() =>
            {




                tareas = gato.Select(async r =>
               {

                   await semaforo.WaitAsync();
                   try
                   {
                       if (progress != null)
                       {
                           i++;
                           _obReq.ModificarRequerimientos(r);
                           _obReq.ObservacionesRequerimientos(r);

                           progress.Report(StaticPercentage.PercentageProgress(i, total));

                       }

                       return r.Modificado;
                   }
                   finally
                   {
                       semaforo.Release();

                   }
               }).ToList();
            });

            await Task.WhenAll(tareas);

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
