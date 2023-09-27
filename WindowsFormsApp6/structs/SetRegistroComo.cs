using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.structs
{
    public class SetRegistroComo : AbstractProgress
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly DataGridView _dgReqActivos2;
        private readonly string _diligencia;
        private readonly Label _lblListo;

        public SetRegistroComo(ToolStripProgressBar progressBar, DataGridView dgReqActivos2, string diligencia, Label lblListo)
        {
            _progressBar = progressBar;
            _dgReqActivos2 = dgReqActivos2;
            _diligencia = diligencia;
            _lblListo = lblListo;
        }

        public async Task SetRegistro()
        {
            await SetRegistroProcess(_dgReqActivos2, _diligencia, reportarProgreso);
        }


        private async Task SetRegistroProcess(DataGridView DgReqActivos2, string diligencia, IProgress<int> progress = null)
        {
            int i = 0;
            int total = DgReqActivos2.Rows.Count;



            await Task.Run(() =>
            {
                if (diligencia != "")
                    foreach (DataGridViewRow dg in DgReqActivos2.Rows)
                    {
                        if (progress != null)
                        {
                            DgReqActivos2.Invoke((MethodInvoker)delegate
                                {
                                    i++;
                                    var respuesta = dg.Cells[5].Value = diligencia;
                                    progress.Report(StaticPercentage.PercentageProgress(i, total));
                                });
                        }

                    }
            });

            MessageBox.Show("Finalizado");

            progress.Report(0);
        }


        public override void ReportarProgreso(int porcentaje)
        {

            _progressBar.Value = porcentaje;

            if (porcentaje != 100 && porcentaje > 0)
            {
                _lblListo.Text = string.Format("procesando...{0}% ", porcentaje);
            }

            else
            {
                _lblListo.Text = "Listo.";
            }



        }
    }
}
