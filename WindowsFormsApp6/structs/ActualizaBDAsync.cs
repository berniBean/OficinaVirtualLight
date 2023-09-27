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


        public ActualizaBDAsync(ToolStripProgressBar progressBar, Label lblProgress, string tipoDato, obtenerRequeridos obReq = null )
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

            await Task.Run(() =>
            {

                tareas= listaClistaRequeridos.Select( async r =>
                {

                    await semaforo.WaitAsync();
                    try
                    {
                        if (progress != null)
                        {
                            i++;
                            if (r.Modificado && r.Estatus != "enviado")
                                    _obReq.ModificarRequerimientos(r);

                            if (r.ModificaObservacion || r.ModificaMalCapturado || r.ModificaNombreNotificador)                            
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
