using CleanArchitecture.ClasesDB;
using CleanArchitecture.Helpers;
using CleanArchitecture.InterfacesUtilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.structs
{
    public class ConvertExcel : AbstractProgress, IWriter<List<ReporteGeneralRequerimientos>>
    {
        private readonly ToolStripProgressBar _progressBar;
        private string _NombreEmision;
        private string _fileName;

        public ConvertExcel(ToolStripProgressBar psBar, string nombreEmision)
        {
            _progressBar = psBar;
            _NombreEmision = nombreEmision;
        }
        public override void ReportarProgreso(int porcentaje)
        {
            _progressBar.Value = porcentaje;
        }


        public async Task Writer(List<ReporteGeneralRequerimientos> data)
        {
            await processWrite(data, reportarProgreso);
        }

        private async Task processWrite(List<ReporteGeneralRequerimientos> data, IProgress<int> progress)
        {
            _fileName = DesktopDirHelper.DireccionDef();
            WriterHelperExcel.CreateDirectory( DesktopDirHelper.DireccionDef());
            string nombre = WriterHelperExcel.GetNameFile(_NombreEmision);

            SLDocument sLDocument = new SLDocument();
            
            DataTable dt = new DataTable();

            dt.Columns.Add("Zona", typeof(string));
            dt.Columns.Add("OHE", typeof(string));
            dt.Columns.Add("Número requerimiento", typeof(string));
            dt.Columns.Add("Número de control", typeof(string));
            dt.Columns.Add("RFC", typeof(string));
            dt.Columns.Add("Razon social", typeof(string));
            dt.Columns.Add("Diligencia", typeof(string));
            dt.Columns.Add("Citatorio", typeof(string));
            dt.Columns.Add("Notificacion", typeof(string));
            dt.Columns.Add("Mal capturado", typeof(string));
            dt.Columns.Add("Observaciones", typeof(string));
            

            int indice = 0;
            foreach (var item in data)
            {
                indice++;
                dt.Rows.Add(item.Zona,
                    item.Ohe,
                    item.NumReq,
                    item.NumCtrl,
                    item.RFC,
                    item.RazonSocial,
                    item.Diligencia,
                    DateFormatHelper.FechaCorta(item.Citatorio),
                    DateFormatHelper.FechaCorta(item.Notificacion),
                    item.MalCaputurado,
                    item.Observaciones);
                progress.Report(StaticPercentage.PercentageProgress(indice, data.Count));
            }

            sLDocument.SetCellValue("A1", "Emision:");
            sLDocument.SetCellValue("A2", "Fecha del reporte:");
            sLDocument.SetCellValue("A3", "Total de requerimientos:");
            sLDocument.SetCellValue("B1", _NombreEmision);
            sLDocument.SetCellValue("B2", DateFormatHelper.FechaLetra(DateTime.Today));
            sLDocument.SetCellValue("B3", data.Count.ToString());


            string finalRo;
            indice = indice + 7;
            finalRo = "K" + indice;
            SLStyle style1 = sLDocument.CreateStyle();
            SLStyle styleBorder = sLDocument.CreateStyle();
            style1.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.LightGray);
            styleBorder.Border.Outline = true;
            styleBorder.Border.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            styleBorder.Border.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            styleBorder.Border.SetTopBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            styleBorder.Border.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            
            sLDocument.SetCellStyle("A7", "K7", style1);
            sLDocument.SetCellStyle("A7", finalRo, styleBorder);            
            sLDocument.ImportDataTable(7, 1, dt, true);
            sLDocument.SaveAs(_fileName + "/" + nombre);
            MessageBox.Show("Finalizado");
            progress.Report(0);
        }
    }
}
