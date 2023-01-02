using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.structs
{
    public class CargaPdf : AbstractProgress
    {
        private pdfAbstract pdfAbstract = new pdfAbstract();
        private readonly ToolStripProgressBar _progressBar;
        obtenerPDFSql _listadoPDF;
        private int _tipoSesion;

        public CargaPdf(ToolStripProgressBar psBar, obtenerPDFSql listadoPDF, int tipoS)
        {
            _progressBar = psBar;
            _listadoPDF = listadoPDF;
            _tipoSesion = tipoS;
        }

        public async Task pdfCargar(IEnumerable<consultaPDF> consulta)
        {
            await procesoCarga(consulta.ToList(), reportarProgreso);
        }

        public async Task pdfDescarga(IEnumerable<consultaPDF> consulta) 
        {
            await ProcesoDescarga(consulta.ToList(), reportarProgreso);
        }

        public void  crearCarpetaFTP(List<consultaPDF> consulta) 
        {
            var result =(from o in consulta select new { o.rutaFtp }).Distinct();

            foreach (var item in result)
            {
                string fin = item.rutaFtp.TrimEnd('/');
                pdfAbstract.crearCarpetaEmision(fin);
            }
            
        }

        private async Task procesoCarga(List<consultaPDF> consulta, IProgress<int> progress)
        {
            int indice = 0;
            foreach (var item in consulta)
            {
                if (progress != null)
                {
                    var paso =new pdfSQL(item.numCtrl, "listo");
                    indice++;
                    await pdfAbstract.cargar(item.rutaFtp, item.name, item.fullName);
                    await modificaEstatus(paso);
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
                        await pdfAbstract.Descarga(item.rutaFtp,item.name, item.numCtrl, fbd.SelectedPath.ToString());
                        progress.Report(StaticPercentage.PercentageProgress(indice, consulta.Count));
                    }

                    
                }
            }

            MessageBox.Show("Carga completada");
            progress.Report(0);


        }

        public override void ReportarProgreso(int porcentaje)
        {
            _progressBar.Value = porcentaje;
        }

        private async Task modificaEstatus(pdfSQL o)
        {
            if (_tipoSesion == 1)
                await _listadoPDF.modificaEstatusPDf(o);
            if (_tipoSesion == 2) 
                await _listadoPDF.modificaEstatusPDf(o);
            if(_tipoSesion == 3)
                await _listadoPDF.modificaEstatusMultaPDf(o);
            if (_tipoSesion == 4)
                await _listadoPDF.modificaEstatusMultaPDf(o);
        }
    }
}
