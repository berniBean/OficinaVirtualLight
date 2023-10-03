using CleanArchitecture.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.structs;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    class ExcelInformeRequermiento : AbstractProgress, IStrategyExcel<CTableroAdminBO>
    {

        private readonly ToolStripLabel _lblStatus;

        public ExcelInformeRequermiento(ToolStripLabel lblStatus)
        {
            _lblStatus = lblStatus;
        }

        public async Task MakeExcelAsync(IEnumerable<CTableroAdminBO> listaRequerimientos, ExcelDataDto datos = null)
        {
            await ExeclProcessAsync(ListadoReq(listaRequerimientos.ToList()), datos, reportarProgreso);
        }

        private List<CTableroAdminBO> ListadoReq(List<CTableroAdminBO> listaRequerimientos)
        {
            var gato = (from item in listaRequerimientos
                        group item by new { item._zona, OHE = item._ohe } into grupo
                        select new CTableroAdminBO
                        {
                            _zona = grupo.Key._zona,
                            _ohe = grupo.Key.OHE,
                            _total = grupo.Count(),
                            _localizado = grupo.Count(d => d._diligencia.Equals("LOCALIZADO")),
                            _noLocalizado = grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")),
                            _noTrabajado = grupo.Count(d => d._diligencia.Equals("NO TRABAJADO")),
                            _pendiente = grupo.Count(d => d._diligencia == null),
                            _pndPDF = grupo.Count(d => d._pdf.Equals("pendiente")),


                        }).ToList();



            return gato;
        }

        private List<CTableroAdminBO> ListadoReqTotales(List<CTableroAdminBO> listaRequerimientos)
        {


            var raton = (from item in listaRequerimientos
                         group item by new { item._tipoc } into grupo
                         select new CTableroAdminBO
                         {
                             _tipoM = grupo.Count(d => d._tipoc.Contains("F")).ToString(),
                             _tipoc = grupo.Count(d => d._tipoc.Contains("M")).ToString(),
                             _total = grupo.Count(),
                             _localizado = grupo.Count(d => d._diligencia.Equals("LOCALIZADO")),
                             _noLocalizado = grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")),
                             _noTrabajado = grupo.Count(d => d._diligencia.Equals("NO TRABAJADO")),
                             _porcentajeFalla = StaticPercentage.PercentageProgress(grupo.Count(d => d._diligencia.Equals("NO LOCALIZADO")), grupo.Count()),
                             _pndPDF = grupo.Count(d => d._pdf.Equals("pendiente"))
                         }).ToList();
            return raton;
        }


        private async Task ExeclProcessAsync(List<CTableroAdminBO> listaRequerimientos, ExcelDataDto _datos, IProgress<int> progress = null)
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<string>>();


            #region ConfiguracionReporteExcel

            Excel.Application miExcel = default(Excel.Application);
            Excel.Workbook libroExcel = default(Excel.Workbook);
            Excel.Worksheet hojaExcel = default(Excel.Worksheet);

            miExcel = new Excel.Application();

            libroExcel = miExcel.Workbooks.Add();


            hojaExcel = libroExcel.Worksheets[1];
            hojaExcel.Name = "Hoja 1";
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;


            hojaExcel.Activate();
         


            Excel.Range oRange;
            Excel.Range objCelda;



            objCelda = hojaExcel.Range["B1", Type.Missing];
            objCelda.Value = _datos.LblEmision;
            oRange = hojaExcel.Range["B1", "F1"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRange.Cells.Locked = true;


            objCelda = hojaExcel.Range["G1", Type.Missing];
            objCelda.Value = "Fecha de corte: " + DateFormatHelper.FechaCorta(DateTime.Now);




            objCelda = hojaExcel.Range["A2", Type.Missing];
            objCelda.Value = "ZONA";

            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "OHE";

            objCelda = hojaExcel.Range["C2", Type.Missing];
            objCelda.Value = "TOTAL";

            objCelda = hojaExcel.Range["D2", Type.Missing];
            objCelda.Value = "LOCALIZADOS";

            objCelda = hojaExcel.Range["E2", Type.Missing];
            objCelda.Value = "NO_LOCALIZADOS";

            objCelda = hojaExcel.Range["F2", Type.Missing];
            objCelda.Value = "NO TRABAJADO";

            objCelda = hojaExcel.Range["G2", Type.Missing];
            objCelda.Value = "PORCENTAJE NO LOCALIZADO";

            objCelda = hojaExcel.Range["H2", Type.Missing];
            objCelda.Value = "PENDIENTE PDF";

            #endregion

            #region OperacionesExcel
            int i = 3;
            int p = 0;
            await Task.Run(() =>
            {


                tareas = listaRequerimientos.Select(async item =>
                {
                    await semaforo.WaitAsync();
                    try
                    {
                        if (progress != null)
                        {



                            hojaExcel.Cells[i, "A"] = item._zona;//tipo multa
                            hojaExcel.Cells[i, "B"] = item._ohe;//Número de multa
                            hojaExcel.Cells[i, "C"] = item._total;//rfc
                            hojaExcel.Cells[i, "D"] = item._localizado;//Número de control SAT
                            hojaExcel.Cells[i, "e"] = item._noLocalizado;//razón social
                            hojaExcel.Cells[i, "F"] = item._noTrabajado;//emisión requerimientos
                            hojaExcel.Cells[i, "G"] = StaticPercentage.PercentageProgress(item._noLocalizado, item._total).ToString() + "%";//fecha notificación
                            hojaExcel.Cells[i, "H"] = item._pndPDF;//fecha vencimiento

                            p++;
                            i++;

                            progress.Report(StaticPercentage.PercentageProgress(p, listaRequerimientos.Count));
                        }

                        return item._zona;


                    }
                    finally
                    {
                        semaforo.Release();
                    }
                }).ToList();

            });

            await Task.WhenAll(tareas);

            string finalRo;


            finalRo = "B" + i ;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = "Total";

            finalRo = "C" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.Total;

            finalRo = "D" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.Localizado;

            finalRo = "E" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.NoLocalizado;

            finalRo = "F" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.NoTrabajado;

            finalRo = "G" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.PorcentajeFalla + "%";

            finalRo = "H" + i;
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.PendientePdf;

            hojaExcel.Columns["A:H"].EntireColumn.AutoFit();

            finalRo = "N" + i;
            oRange = hojaExcel.Range["H2", finalRo];
            oRange.CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;


            finalRo = "D" + (i + 3);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = "FISICAS";


            finalRo = "E" + (i + 3);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.Fisicas;

            finalRo = "D" + (i + 4);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = "MORALES";

            finalRo = "E" + (i + 4);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.Morales;

            finalRo = "D" + (i + 5);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = "TOTALES";

            finalRo = "E" + (i + 5);
            objCelda = hojaExcel.Range[finalRo];
            objCelda.Value = _datos.Total;


            oRange = hojaExcel.Range["D" + (i + 3) + ":" + "E" + (i + 5)];
            oRange.CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;






            string s = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string ruta = s + "\\RIF";


            if (listaRequerimientos.Count == 0)
                MessageBox.Show("Sin registros paraenviar");
            else
            {

                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);
                try
                {

                    libroExcel.SaveAs(s + @"\RIF\" + _datos.Name);
                    libroExcel.Close();
                    releaseObject(libroExcel);
                    MessageBox.Show("Libro guardado en Escritorio\\RIF");
                }
                catch (COMException ce)
                {

                    if ((uint)ce.ErrorCode == 0x800A03EC)
                    {
                        libroExcel.Close();
                        releaseObject(libroExcel);
                    }


                }
            }
            progress.Report(0);
            #endregion
        }


        private void releaseObject(object ob)
        {

            try
            {
                Marshal.ReleaseComObject(ob);
                ob = null;
            }
            catch (Exception ex)
            {

                ob = null;
                MessageBox.Show("Error al liberar" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public override void ReportarProgreso(int porcentaje)
        {


            if (porcentaje != 100 && porcentaje > 0)
            {
                _lblStatus.Text = string.Format("Agregando registros  {0}%", porcentaje);

            }
            else
            {
                _lblStatus.Text = "Proceso completado.";
            }
        }


    }
}
