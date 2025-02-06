using CleanArchitecture.Helpers;
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
    public class SpreadRequerimientoSinDato : AbstractProgress, IStrategyExcel<CListaRequeridosBO>
    {
        private readonly ToolStripProgressBar _progressBar;
        private readonly ToolStripStatusLabel _tsStatus;
        private readonly System.Windows.Forms.Label _lblProgress;

        public SpreadRequerimientoSinDato(ToolStripProgressBar progressBar, ToolStripStatusLabel tsStatus, System.Windows.Forms.Label lblProgress)
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

            // Crear un nuevo documento de SpreadsheetLight
            SLDocument sl = new SLDocument();

            // Seleccionar la primera hoja
            SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
            int startRowIndex = stats.StartRowIndex;
            int startColumnIndex = stats.StartColumnIndex;

            // Cambiar el nombre de la hoja
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, _datos.Name);

            // Configurar el rango y aplicar formato
            SLStyle style = new SLStyle();
            style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.LightGray);
            style.Fill.SetPatternForegroundColor(System.Drawing.Color.LightGray); // ColorIndex 15
            sl.SetCellValue("A7", "Num");
            sl.SetCellValue("B7", "RFC");
            sl.SetCellValue("C7", "NUM_CONTROL");
            sl.SetCellValue("D7", "RAZÓN SOCIAL");
            sl.SetCellValue("E7", "LOCALIDAD");
            sl.SetCellValue("F7", "FECHA \nACTA / NO LOCALIZADO");
            sl.SetCellValue("G7", "FECHA DE \nCITATORIO");
            sl.SetCellValue("H7", "FECHA DE \nNOTIFICACION");
            sl.SetCellValue("I7", "OFICIO \nENVIO A SEFIPLAN");
            sl.SetCellValue("J7", "FECHA DE \nENVIO A SEFIPLAN");
            sl.SetCellValue("K7", "FECHA \n DE ENTREGA \nAL NOTIFICADOR");
            sl.SetCellValue("L7", "NOMBRE DEL \nNOTIFICADOR");

            // Aplicar colores a las celdas
            style.Fill.SetPatternForegroundColor(System.Drawing.Color.LightGray); // ColorIndex 15
            sl.SetCellStyle("A7", "E7", style);

            style.Fill.SetPatternForegroundColor(System.Drawing.Color.LightBlue); // ColorIndex 16
            sl.SetCellStyle("F7", "J7", style);

            style.Fill.SetPatternForegroundColor(System.Drawing.Color.Red); // ColorIndex 3
            sl.SetCellStyle("K7", "L7", style);

            // Ajustar el ancho de las columnas
            sl.SetColumnWidth("E7", "L7", 15);

            // Escribir datos en las celdas
            sl.SetCellValue("B1", "REF_NUM");
            sl.SetCellValue("C1", _datos.NombreEmision);
            sl.MergeWorksheetCells("C1", "D1");

            sl.SetCellValue("B2", "ZONA");
            sl.SetCellValue("C2", _datos.LblZonaName);
            sl.MergeWorksheetCells("C2", "D2");

            sl.SetCellValue("B3", "OHE");
            sl.SetCellValue("C3", _datos.CmbOHE);
            sl.MergeWorksheetCells("C3", "D3");

            sl.SetCellValue("B4", "Fecha emisión");
            sl.SetCellValue("C4", _datos.FechaEmision.ToString("dd \"de\" MMMM \"de\" yyyy"));
            sl.MergeWorksheetCells("C4", "D4");

            sl.SetCellValue("B5", "Total requerimientos:");
            sl.SetCellValue("C5", listaRequerimientos.Count);
            sl.MergeWorksheetCells("C5", "D5");
            sl.SetCellStyle("C5", "D5", new SLStyle { Alignment = { Horizontal = HorizontalAlignmentValues.Left } });


            #region addData
            int i = 8; // Fila inicial para escribir los datos
            int p = 0; // Contador de progreso

            await Task.Run(async () =>
            {
                var tareas = listaRequerimientos.Select(async item =>
                {
                    await semaforo.WaitAsync(); // Esperar el semáforo para controlar el acceso concurrente
                    try
                    {
                        if (progress != null)
                        {
                            // Escribir los datos en las celdas correspondientes
                            sl.SetCellValue(i, 1, item.NumReq.ToString("000000")); // Columna A (Num)
                            sl.SetCellValue(i, 2, item.Rfc.ToString()); // Columna B (RFC)
                            sl.SetCellValue(i, 3, item.NumCtrl.ToString()); // Columna C (NUM_CONTROL)
                            sl.SetCellValue(i, 4, item.RazonSocial.ToString()); // Columna D (RAZÓN SOCIAL)
                            sl.SetCellValue(i, 5, item.Localidad.ToString()); // Columna E (LOCALIDAD)
                            sl.SetCellValue(i, 6, item.Diligencia == "NO LOCALIZADO" ? DateFormatHelper.FechaCorta(item.FechaNotificacion) : ""); // Columna F (FECHA ACTA / NO LOCALIZADO)
                            sl.SetCellValue(i, 7, DateFormatHelper.FechaCorta(item.FechaCitatorio)); // Columna G (FECHA DE CITATORIO)
                            sl.SetCellValue(i, 8, item.Diligencia == "LOCALIZADO" ? DateFormatHelper.FechaCorta(item.FechaNotificacion) : ""); // Columna H (FECHA DE NOTIFICACION)
                            sl.SetCellValue(i, 9, item.OficioSEFIPLAN); // Columna I (OFICIO ENVIO A SEFIPLAN)
                            sl.SetCellValue(i, 10, DateFormatHelper.FechaCorta(item.FechaEnvioSefiplan)); // Columna J (FECHA DE ENVIO A SEFIPLAN)
                            sl.SetCellValue(i, 11, DateFormatHelper.FechaCorta(item.FechaEntregaNotificador)); // Columna K (FECHA DE ENTREGA AL NOTIFICADOR)
                            sl.SetCellValue(i, 12, item.NombreNotificador); // Columna L (NOMBRE DEL NOTIFICADOR)

                            p++; // Incrementar el contador de progreso
                            i++; // Mover a la siguiente fila

                            // Reportar el progreso
                            progress.Report(StaticPercentage.PercentageProgress(p, listaRequerimientos.Count));
                        }

                        return item.Modificado;
                    }
                    finally
                    {
                        semaforo.Release(); // Liberar el semáforo
                    }
                }).ToList();

                // Esperar a que todas las tareas se completen
                await Task.WhenAll(tareas);
            });
            #endregion

            sl.AutoFitColumn(1, 5); // Columnas A (1) a E (5)

            // Definir el rango final para aplicar bordes
            string finalRo = "L" + i; // Por ejemplo, "L20" si i = 20



            // Habilitar el ajuste de texto en la fila 7
            SLStyle estiloAjusteTexto = new SLStyle();
            estiloAjusteTexto.Alignment.WrapText = true; // Ajustar texto

            // Aplicar el estilo a toda la fila 7
            sl.SetRowStyle(7, estiloAjusteTexto);

            // Aplicar bordes continuos al rango
            SLStyle borderStyle = new SLStyle();
            borderStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            borderStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            borderStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            borderStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            sl.SetCellStyle("A7", finalRo, borderStyle);

            // Bloquear celdas en el rango A7:L7
            SLStyle lockedStyle = new SLStyle();
            lockedStyle.Protection.Locked = true;
            sl.SetCellStyle("A7", "L7", lockedStyle);

            // Desbloquear celdas en el rango F8:finalRo
            SLStyle unlockedStyle = new SLStyle();
            unlockedStyle.Protection.Locked = false;
            sl.SetCellStyle("F8", finalRo, unlockedStyle);

            // Proteger la hoja (opcional, si es necesario)
            // sl.ProtectWorksheet("vicrif", true); // Descomenta si necesitas protección

            #region Guardar el archivo

            // Obtener la ruta del escritorio
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaCompleta = Path.Combine(rutaEscritorio, "RIF");

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCompleta))
            {
                Directory.CreateDirectory(rutaCompleta);
            }

            try
            {
                // Guardar el archivo en la ruta especificada
                string fileName = $"{_datos.LblEmision}_{sl.GetCurrentWorksheetName()} {_datos.CmbOHE}_{listaRequerimientos.Count}.xlsx";
                string fullPath = Path.Combine(rutaCompleta, fileName);
                sl.SaveAs(fullPath);

                // Mostrar mensaje de éxito
                MessageBox.Show("Libro guardado en Escritorio\\RIF");
            }
            catch (Exception ex)
            {
                // Manejar errores al guardar
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}");
            }

            #endregion



            // Reiniciar el progreso
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
