using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper;

namespace WindowsFormsApp6.structs
{
    public class CargaOficiosPDF : AbstractProgress
    {
        private pdfAbstract pdfAbstract = new pdfAbstract();
        private readonly ToolStripProgressBar _progressBar;
        obtenerPDFSql _listadoPDF;
        private int _tipoSesion;

        public CargaOficiosPDF()
        {

        }

        public CargaOficiosPDF(ToolStripProgressBar progressBar, obtenerPDFSql listadoPDF, int tipoSesion)
        {
            _progressBar = progressBar;
            _listadoPDF = listadoPDF;
            _tipoSesion = tipoSesion;
        }

        public async Task pdfCargar(IEnumerable<consultaPDF> consulta)
        {
            await procesoCarga(consulta.ToList(), reportarProgreso);
        }

        public async Task pdfDescarga(IEnumerable<consultaPDF> consulta)
        {
            await ProcesoDescarga(consulta.ToList(), reportarProgreso);
        }

        public void crearCarpetaFTP(List<consultaPDF> consulta)
        {
            var result = (from o in consulta select new { o.rutaFtp }).Distinct();



            //var carpetaSecundaria = NumberOrderHelper.ObtenerUrlSecundarias(result.FirstOrDefault().ToString());

            var ftpAddress = NumberOrderHelper.ObtenerUrlSecundarias(result.FirstOrDefault().ToString().Replace("rutaFtp = ", "").Replace("{", "").Replace("}", ""));

            pdfAbstract.crearCarpetaEmision(ftpAddress.ToString());



            MessageBox.Show(ftpAddress.ToString());

            foreach (var item in result)
            {
                string fin = item.rutaFtp.TrimEnd('/');
                pdfAbstract.crearCarpetaEmision(fin);
            }

        }

        private async Task procesoCarga(List<consultaPDF> consulta, IProgress<int> progress)
        {
            var listado = consulta.OrderBy(x => NumberOrderHelper.ObtenerNumeroAntesGuionBajo(x.name));
            int indice = 0;
            foreach (var item in listado)
            {
                if (progress != null)
                {

                    indice++;
                    await pdfAbstract.cargar(item.rutaFtp, item.name, item.fullName);
                    progress.Report(StaticPercentage.PercentageProgress(indice, consulta.Count));
                }


            }

            MessageBox.Show("Carga completada");
            progress.Report(0);
        }

        private async Task ProcesoDescarga(List<consultaPDF> consulta, IProgress<int> progress)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    int indice = 0;
                    foreach (var item in consulta)
                    {
                        indice++;
                        await pdfAbstract.Descarga(item.rutaFtp, item.name, item.numCtrl, fbd.SelectedPath.ToString());
                        progress.Report(StaticPercentage.PercentageProgress(indice, consulta.Count));
                    }


                }
            }

            MessageBox.Show("Carga completada");
            progress.Report(0);


        }

        public override void ReportarProgreso(int porcentaje)
        {

            if (_progressBar != null)
                _progressBar.Value = porcentaje;


        }
    }
}
