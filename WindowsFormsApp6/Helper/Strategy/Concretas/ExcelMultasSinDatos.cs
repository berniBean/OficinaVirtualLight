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
    class ExcelMultasSinDatos : AbstractProgress, IStrategyExcel<CListaRequeridosBO>
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly ToolStripStatusLabel _tsStatus;
        private readonly Label _lblProgress;

        public ExcelMultasSinDatos(ToolStripProgressBar progressBar, ToolStripStatusLabel tsStatus, Label lblProgress)
        {
            _progressBar = progressBar;
            _tsStatus = tsStatus;
            _lblProgress = lblProgress;
        }

        public async Task MakeExcelAsync(IEnumerable<CListaRequeridosBO> listaRequerimientos, ExcelDataDto datos)
        {
            await ExeclProcessAsync(listaRequerimientos.ToList(), datos, reportarProgreso);
        }

        private async Task ExeclProcessAsync(List<CListaRequeridosBO> listaRequerimientos, ExcelDataDto _datos, IProgress<int> progress = null)
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();

            #region ConfiguracionReporteExcel
            Excel.Application miExcel = default(Excel.Application);
            Excel.Workbook libroExcel = default(Excel.Workbook);
            Excel.Worksheet hojaExcel = default(Excel.Worksheet);

            miExcel = new Excel.Application();
            libroExcel = miExcel.Workbooks.Add();

            hojaExcel = libroExcel.Worksheets[1];
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;
            hojaExcel.Name = _datos.LblEmision;


            hojaExcel.Activate();

            Excel.Range oRange;
            Excel.Range objCelda;


            oRange = hojaExcel.Range["A7", "E7"];
            oRange.Interior.ColorIndex = 15;
            oRange = hojaExcel.Range["F7", "J7"];
            oRange.Interior.ColorIndex = 16;

            oRange = hojaExcel.Range["K7", "M7"];
            oRange.Interior.ColorIndex = 3;

            oRange = hojaExcel.Range["E7", "M7"];
            oRange.ColumnWidth = 15;

            oRange = hojaExcel.Range["N7", "N7"];
            oRange.ColumnWidth = 36;

            oRange = hojaExcel.Range["N7", "N7"];
            oRange.Interior.ColorIndex = 16;




            //referencia general multa RIF [ref_num]
            objCelda = hojaExcel.Range["B1", Type.Missing];
            objCelda.Value = "REF_NUM";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C1", "D1"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            //oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = _datos.LblEmision;


            oRange.Cells.Locked = true;
            //referencia general multa RIF [ZONA]
            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "ZONA";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C2", "D2"];//ZONA
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = _datos.LblZonaName;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [OHE]
            objCelda = hojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "OHE";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C3", "D3"];//OHE
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = _datos.CmbOHE;
            oRange.Cells.Locked = true;



            //referencia general multa RIF [FECHA EMISIÓN]
            objCelda = hojaExcel.Range["B4", Type.Missing];
            objCelda.Value = "Fecha emisión";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C4", "D4"];//FECHA EMISIÓN
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = _datos.FechaEmision;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [TOTAL REQUERIMIENTOS]
            objCelda = hojaExcel.Range["B5", Type.Missing];
            objCelda.Value = "Total requerimientos:";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C5", "D5"];//TOTAL REQUERIMIENTOS
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = listaRequerimientos.Count;
            oRange.Locked = true;




            objCelda = hojaExcel.Range["A7", Type.Missing];
            objCelda.Value = "TIPO MULTA";

            objCelda = hojaExcel.Range["B7", Type.Missing];
            objCelda.Value = "NÚMERO \nDE MULTA";

            objCelda = hojaExcel.Range["C7", Type.Missing];
            objCelda.Value = "RFC";

            objCelda = hojaExcel.Range["D7", Type.Missing];
            objCelda.Value = "NÚMERO DE CONTROL SAT";

            objCelda = hojaExcel.Range["E7", Type.Missing];
            objCelda.Value = "RAZÓN SOCIAL";

            objCelda = hojaExcel.Range["F7", Type.Missing];
            objCelda.Value = "EMISION REQUERIMIENTO";

            objCelda = hojaExcel.Range["G7", Type.Missing];
            objCelda.Value = "NUMERO DE \nREQUERIMIENTO";

            objCelda = hojaExcel.Range["H7", Type.Missing];
            objCelda.Value = "LOCALIZADO \nNO LOCALIZADO";

            objCelda = hojaExcel.Range["I7", Type.Missing];
            objCelda.Value = "FECHA \nCITATORIO";

            objCelda = hojaExcel.Range["J7", Type.Missing];
            objCelda.Value = "FECHA DE \nNOTIFICACIÓN";

            objCelda = hojaExcel.Range["K7", Type.Missing];
            objCelda.Value = "FECHA DE \nPAGO";

            objCelda = hojaExcel.Range["L7", Type.Missing];
            objCelda.Value = "IMPORTE";

            objCelda = hojaExcel.Range["M7", Type.Missing];
            objCelda.Value = "CUMPLIO \nANTES";

            objCelda = hojaExcel.Range["N7", Type.Missing];
            objCelda.Value = "OBSERVACIONES";
            #endregion

            #region OperacionesExcel
            int i = 8;
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
                            hojaExcel.Cells[i, "B"].NumberFormat = "000000";
                            hojaExcel.Cells[i, "G"].NumberFormat = "000000";


                            hojaExcel.Cells[i, "A"] = item._tipoMulta;//tipo multa
                            hojaExcel.Cells[i, "B"] = item._numMulta;//Número de multa
                            hojaExcel.Cells[i, "C"] = item.Rfc;//rfc
                            hojaExcel.Cells[i, "D"] = item.NumCtrl;//Número de control SAT
                            hojaExcel.Cells[i, "E"] = item.RazonSocial;//razón social
                            hojaExcel.Cells[i, "F"] = item._detalleEmision;//emisión requerimientos
                            hojaExcel.Cells[i, "G"] = item.NumReq;//número de requerimiento

                            p++;
                            i++;

                            progress.Report(StaticPercentage.PercentageProgress(p, listaRequerimientos.Count));
                        }

                        return item.Modificado;


                    }
                    finally
                    {
                        semaforo.Release();
                    }
                }).ToList();

            });

            await Task.WhenAll(tareas);



            hojaExcel.Columns["A:G"].EntireColumn.AutoFit();
            string finalRo;
            finalRo = "N" + i;
            oRange = hojaExcel.Range["G7", finalRo];
            oRange.CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = hojaExcel.Range["A7", "N7"];
            oRange.Cells.Locked = true;

            oRange = hojaExcel.Range["H8", finalRo];
            oRange.Cells.Locked = false;

            hojaExcel.Protect("vicrif", true);

            string s = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string ruta = s + "\\RIF";

            if (!Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);
            try
            {
                

                libroExcel.SaveAs(s + @"\RIF\" + _datos.TipoMultaEmision + hojaExcel.Name + "_" + _datos.CmbOHE + "_" + listaRequerimientos.Count.ToString() + ".xls");
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
            _progressBar.Value = porcentaje;

            if (porcentaje != 100 && porcentaje > 0)
            {
                _tsStatus.Text = string.Format("Agregando registros  {0}%", porcentaje);

            }
            else
            {
                _tsStatus.Text = "Proceso completado.";
            }
        }
    }
}
