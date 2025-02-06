

using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6.Helper.Strategy.Concretas
{
    public class SpreadMultaSinDatos : AbstractProgress, IStrategyExcel<CListaRequeridosBO>
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly ToolStripStatusLabel _tsStatus;
        private readonly Label _lblProgress;

        public SpreadMultaSinDatos(ToolStripProgressBar progressBar, ToolStripStatusLabel tsStatus, Label lblProgress)
        {
            _progressBar = progressBar;
            _tsStatus = tsStatus;
            _lblProgress = lblProgress;
        }

        public async Task MakeExcelAsync(IEnumerable<CListaRequeridosBO> listaRequerimientos, ExcelDataDto datos = null)
        {
            await SpreadExeclProcessAsync(listaRequerimientos.ToList(), datos, reportarProgreso);
        }

        private async Task SpreadExeclProcessAsync(List<CListaRequeridosBO> listaRequerimientos, ExcelDataDto _datos, IProgress<int> progress = null)
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();

            // Crear un nuevo documento de Excel
            SLDocument sl = new SLDocument();

            // Obtener la primera hoja
            SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
            string sheetName = sl.GetSheetNames()[0];
            sl.SelectWorksheet(sheetName);

            // Establecer el nombre de la hoja
            sl.RenameWorksheet(sheetName, _datos.LblEmision);

            // Aplicar formato a las celdas
            SLStyle headerStyle = new SLStyle();
            headerStyle.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.LightGray);
            headerStyle.Font.Bold = true;
            headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            // Aplicar colores y anchos de columna
            sl.SetCellValue("A7", "TIPO MULTA");
            sl.SetCellValue("B7", "NÚMERO \nDE MULTA");
            sl.SetCellValue("C7", "RFC");
            sl.SetCellValue("D7", "NÚMERO DE CONTROL SAT");
            sl.SetCellValue("E7", "RAZÓN SOCIAL");
            sl.SetCellValue("F7", "EMISION REQUERIMIENTO");
            sl.SetCellValue("G7", "NUMERO DE \nREQUERIMIENTO");
            sl.SetCellValue("H7", "LOCALIZADO \nNO LOCALIZADO");
            sl.SetCellValue("I7", "FECHA \nCITATORIO");
            sl.SetCellValue("J7", "FECHA DE \nNOTIFICACIÓN");
            sl.SetCellValue("K7", "FECHA DE \nPAGO");
            sl.SetCellValue("L7", "IMPORTE");
            sl.SetCellValue("M7", "CUMPLIO \nANTES");
            sl.SetCellValue("N7", "OBSERVACIONES");

            // Aplicar estilo a los encabezados
            sl.SetCellStyle("A7", "N7", headerStyle);

            // Aplicar colores de fondo a rangos específicos
            SLStyle colorStyle1 = new SLStyle();
            colorStyle1.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.FromArgb(192, 192, 192), System.Drawing.Color.FromArgb(192, 192, 192)); // ColorIndex 15
            sl.SetCellStyle("A7", "E7", colorStyle1);

            SLStyle colorStyle2 = new SLStyle();
            colorStyle2.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.FromArgb(153, 204, 255), System.Drawing.Color.FromArgb(153, 204, 255)); // ColorIndex 16
            sl.SetCellStyle("F7", "J7", colorStyle2);

            SLStyle colorStyle3 = new SLStyle();
            colorStyle3.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Red, System.Drawing.Color.Red); // ColorIndex 3
            sl.SetCellStyle("K7", "M7", colorStyle3);

            SLStyle colorStyle4 = new SLStyle();
            colorStyle4.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.FromArgb(153, 204, 255), System.Drawing.Color.FromArgb(153, 204, 255)); // ColorIndex 16
            sl.SetCellStyle("N7", "N7", colorStyle4);

            // Ajustar el ancho de las columnas
            sl.SetColumnWidth(5, 15); // Columna E
            sl.SetColumnWidth(6, 15); // Columna F
            sl.SetColumnWidth(7, 15); // Columna G
            sl.SetColumnWidth(8, 15); // Columna H
            sl.SetColumnWidth(9, 15); // Columna I
            sl.SetColumnWidth(10, 15); // Columna J
            sl.SetColumnWidth(11, 15); // Columna K
            sl.SetColumnWidth(12, 15); // Columna L
            sl.SetColumnWidth(13, 15); // Columna M
            sl.SetColumnWidth(14, 36); // Columna N

            // Referencia general multa RIF [ref_num]
            sl.SetCellValue("B1", "REF_NUM");
            sl.SetCellValue("C1", _datos.LblEmision);
            sl.MergeWorksheetCells("C1", "D1");
            sl.SetCellStyle("C1", "D1", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left } });

            // Referencia general multa RIF [ZONA]
            sl.SetCellValue("B2", "ZONA");
            sl.SetCellValue("C2", _datos.LblZonaName);
            sl.MergeWorksheetCells("C2", "D2");
            sl.SetCellStyle("C2", "D2", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left } });

            // Referencia general multa RIF [OHE]
            sl.SetCellValue("B3", "OHE");
            sl.SetCellValue("C3", _datos.CmbOHE);
            sl.MergeWorksheetCells("C3", "D3");
            sl.SetCellStyle("C3", "D3", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left } });

            // Referencia general multa RIF [FECHA EMISIÓN]
            sl.SetCellValue("B4", "Fecha emisión");
            sl.SetCellValue("C4", _datos.FechaEmision);
            sl.MergeWorksheetCells("C4", "D4");
            sl.SetCellStyle("C4", "D4", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left }, FormatCode = "dd \"de\" mmmm \"de\" yyyy" });

            // Referencia general multa RIF [TOTAL REQUERIMIENTOS]
            sl.SetCellValue("B5", "Total requerimientos:");
            sl.SetCellValue("C5", listaRequerimientos.Count.ToString());
            sl.MergeWorksheetCells("C5", "D5");
            sl.SetCellStyle("C5", "D5", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left } });

            #region OpAgregacion
            int i = 8;
            int p = 0;
            await Task.Run(() =>
            {
                tareas = listaRequerimientos.Select(async item =>
                {
                    await semaforo.WaitAsync();
                    try
                    {
                        // Formato de celdas
                        sl.SetCellValue(i, 2, item._numMulta); // Columna B
                        sl.SetCellValue(i, 7, item.NumReq); // Columna G
                        sl.SetCellStyle(i, 2, new SLStyle { FormatCode = "000000" }); // Formato de número
                        sl.SetCellStyle(i, 7, new SLStyle { FormatCode = "000000" }); // Formato de número

                        // Asignar valores a las celdas
                        sl.SetCellValue(i, 1, item._tipoMulta); // Columna A
                        sl.SetCellValue(i, 2, item._numMulta); // Columna B
                        sl.SetCellValue(i, 3, item.Rfc); // Columna C
                        sl.SetCellValue(i, 4, item.NumCtrl); // Columna D
                        sl.SetCellValue(i, 5, item.RazonSocial); // Columna E
                        sl.SetCellValue(i, 6, item._detalleEmision); // Columna F
                        sl.SetCellValue(i, 7, item.NumReq); // Columna G

                        // Incrementar contadores
                        p++;
                        i++;

                        // Reportar progreso (si es necesario)
                        if (progress != null)
                        {
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
            #endregion

            // Autoajustar las columnas A a G
            for (int col = 1; col <= 7; col++) // Columnas A (1) a G (7)
            {
                sl.AutoFitColumn(col);
            }

            string finalRo = "N" + i;

            // Habilitar el ajuste de texto en la fila 7
            SLStyle estiloAjusteTexto = new SLStyle();
            estiloAjusteTexto.Alignment.WrapText = true; // Ajustar texto

            // Aplicar el estilo a toda la fila 7
            sl.SetRowStyle(7, estiloAjusteTexto);

            // Aplicar bordes a un rango (G7 hasta finalRo)
            SLStyle estiloBorde = new SLStyle();
            estiloBorde.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estiloBorde.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloBorde.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estiloBorde.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;


            sl.SetCellStyle("A7", finalRo, estiloBorde);

            // Bloquear celdas (A7 hasta N7)
            SLStyle estiloBloqueado = new SLStyle();
            estiloBloqueado.Protection.Locked = true;
            sl.SetCellStyle("A7", "N7", estiloBloqueado);

            // Desbloquear celdas (H8 hasta finalRo)
            SLStyle estiloDesbloqueado = new SLStyle();
            estiloDesbloqueado.Protection.Locked = false;
            sl.SetCellStyle("H8", finalRo, estiloDesbloqueado);

            // Proteger la hoja con contraseña
            //sl.ProtectWorksheet("vicrif");

            // Guardar el archivo en el escritorio
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaCompleta = Path.Combine(rutaEscritorio, "RIF");

            if (!Directory.Exists(rutaCompleta))
            {
                Directory.CreateDirectory(rutaCompleta);
            }

            string nombreArchivo = $"{_datos.TipoMultaEmision}_{_datos.LblEmision}_{_datos.CmbOHE}_{listaRequerimientos.Count}.xls";
            string rutaArchivo = Path.Combine(rutaCompleta, nombreArchivo);

            try
            {
                sl.SaveAs(rutaArchivo);
                MessageBox.Show("Libro guardado en Escritorio\\RIF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }

            progress.Report(0);
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
