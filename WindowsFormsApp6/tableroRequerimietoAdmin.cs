using System.Windows.Forms;
using System;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using System.ComponentModel;
using wpfCreaExcel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp6
{
    public partial class tableroRequerimietoAdmin : Form
    {
        private int  idEmision;
        private string OHE;
        private string ZONA;
        private string totalReq;
        private string referenciaEmision;
        private string nombreEmision;
        private DateTime fechaImpresion;
        
        private CCCInformeAvanceBll bdAvance = new CCCInformeAvanceBll();
        private CInformeAvance obListaAvance = new CInformeAvance();
        private ListaInformeAvance listAvance;

        private ListCoheActivaBLL bdReq = new ListCoheActivaBLL();
        private CListaRequeridosBO obListaRqe = new CListaRequeridosBO();
        private ListaClistaRequeridos listReq;

        private CCNombreBimestreBLL bdNombreBim = new CCNombreBimestreBLL();
        private CNombreBimestreBO obListaNomBim = new CNombreBimestreBO();
        private ListaCNombreBimestre listNomBim;



        public tableroRequerimietoAdmin()
        {
            InitializeComponent();
            loadEmision();
            cargarAvanceZona(idEmision);
            dgAvanceZona.AutoResizeColumns();
            dgAvanceZona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgRequerimientos.AutoResizeColumns();
            dgRequerimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cargarAvanceZona(int emision) 
        {
            listAvance = bdAvance.GetAvanceAdmin(emision);
            listaInformeAvanceBindingSource.DataSource = listAvance;
        }

        private void cargarRequerimientosRIF()
        {
            if (btnExcel.Enabled == false)
                btnExcel.Enabled = true;
            if (tsBusqueda.Enabled == false)
                tsBusqueda.Enabled = true;

            listReq = bdReq.GatReqGetRequerimientos(Convert.ToString(idEmision), OHE);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgRequerimientos.DataSource = cListaRequeridosBOBindingSource;
            dgRequerimientos.AutoResizeColumns();
            dgRequerimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void loadEmision()
        {
            idEmision = CUserLoggin.idEmision;
            tsBusqueda.Enabled = false;
            btnExcel.Enabled = false;
            
            
        }

        private void busquedaLista()
        {
            listReq = bdReq.GetListaBusqueda(Convert.ToString(idEmision), OHE, tsBusqueda.Text);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgRequerimientos.DataSource = cListaRequeridosBOBindingSource;
        }

        private void dgAvanceZona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ZONA = dgAvanceZona.Rows[e.RowIndex].Cells[0].Value.ToString();
            OHE = dgAvanceZona.Rows[e.RowIndex].Cells[1].Value.ToString();
            totalReq = dgAvanceZona.Rows[e.RowIndex].Cells[2].Value.ToString();
            referenciaEmision = dgAvanceZona.Rows[e.RowIndex].Cells[8].Value.ToString();
            fechaImpresion= Convert.ToDateTime (dgAvanceZona.Rows[e.RowIndex].Cells[9].Value.ToString());
            nombreEmision = dgAvanceZona.Rows[e.RowIndex].Cells[10].Value.ToString();

            cargarRequerimientosRIF();

        }

        private void tsBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {  
                if (!string.IsNullOrEmpty(tsBusqueda.Text))
                {

                    busquedaLista();

                }

                else
                        cargarRequerimientosRIF();

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            tsBusqueda.Enabled = false;
            btnExcel.Enabled = false;
            dgAvanceZona.Enabled = false;
            dgRequerimientos.Enabled = false;
            bindingNavigator1.Enabled = false;
            try
            {
                BackgroundWorker _hilo1 = new BackgroundWorker();
                _hilo1.DoWork += new DoWorkEventHandler(excelDatos);
                _hilo1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_hilo1_RunWorkerCompleted);
                _hilo1.ProgressChanged += new ProgressChangedEventHandler(_hilo1_ProgressChanged);

                TaskInfo ti = new TaskInfo();

                ti.cmbOHE = OHE;
                ti.CmbEmision = Convert.ToString( idEmision);
                ti.DatosRif = dgRequerimientos;
                ti.mensaje = "Procesando carga de datos . . .";

                _hilo1.RunWorkerAsync(ti);

            }
            catch (Exception ex)
            {


                lblStatus.Text += ex.Source.ToString() + " - " + ex.Message + "\r\n";

            }
        }
        private void excelDatos(Object sender, DoWorkEventArgs e)
        {
            TaskInfo ti = (TaskInfo)e.Argument;
            BackgroundWorker bw = sender as BackgroundWorker;

            //extrae el argumento

            ti.mensaje = "Procesando datos ";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);


            int finalRow;
            Excel.Application miExcel = default(Excel.Application);
            Excel.Workbook libroExcel = default(Excel.Workbook);
            Excel.Worksheet hojaExcel = default(Excel.Worksheet);



            miExcel = new Excel.Application();
            //miExcel.Visible = true;

            libroExcel = miExcel.Workbooks.Add();

            hojaExcel = libroExcel.Worksheets[1];
            hojaExcel.Name = nombreEmision;
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            ti.max = Convert.ToInt16( totalReq);
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);

            hojaExcel.Activate();

            Excel.Range oRange;
            Excel.Range objCelda;

            oRange = hojaExcel.Range["A7", "E7"];
            oRange.Interior.ColorIndex = 15;
            oRange = hojaExcel.Range["F7", "J7"];
            oRange.Interior.ColorIndex = 16;

            oRange = hojaExcel.Range["K7", "L7"];
            oRange.Interior.ColorIndex = 3;

            oRange = hojaExcel.Range["E7", "L7"];
            oRange.ColumnWidth = 15;



            objCelda = hojaExcel.Range["B1", Type.Missing];
            objCelda.Value = "REF_NUM";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C1", "D1"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = referenciaEmision;


            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "ZONA";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C2", "D2"];//zona
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = ZONA;
            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "OHE";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C3", "D3"];//oficina de hacienda
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = OHE;
            oRange.Cells.Locked = true;




            objCelda = hojaExcel.Range["B4", Type.Missing];
            objCelda.Value = "Fecha emisión";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C4", "D4"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = e.Result = fechaImpresion;
            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B5", Type.Missing];
            objCelda.Value = "Total requerimientos:";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C5", "D5"];
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = totalReq;
            oRange.Locked = true;




            objCelda = hojaExcel.Range["A7", Type.Missing];
            objCelda.Value = "Num";

            objCelda = hojaExcel.Range["B7", Type.Missing];
            objCelda.Value = "RFC";

            objCelda = hojaExcel.Range["C7", Type.Missing];
            objCelda.Value = "NUM_CONTROL";

            objCelda = hojaExcel.Range["D7", Type.Missing];
            objCelda.Value = "RAZÓN SOCIAL";

            objCelda = hojaExcel.Range["E7", Type.Missing];
            objCelda.Value = "LOCALIDAD";

            objCelda = hojaExcel.Range["F7", Type.Missing];
            objCelda.Value = "FECHA \nACTA / NO LOCALIZADO";

            objCelda = hojaExcel.Range["G7", Type.Missing];
            objCelda.Value = "FECHA DE \nCITATORIO";

            objCelda = hojaExcel.Range["H7", Type.Missing];
            objCelda.Value = "FECHA DE \nNOTIFICACION";

            objCelda = hojaExcel.Range["I7", Type.Missing];
            objCelda.Value = "OFICIO \nENVIO A SEFIPLAN";

            objCelda = hojaExcel.Range["J7", Type.Missing];
            objCelda.Value = "FECHA DE \nENVIO A SEFIPLAN";

            objCelda = hojaExcel.Range["K7", Type.Missing];
            objCelda.Value = "FECHA \n DE ENTREGA \nAL NOTIFICADOR";

            objCelda = hojaExcel.Range["L7", Type.Missing];
            objCelda.Value = "NOMBRE DEL \nNOTIFICADOR";




            int i = 8;
            int p = 0;
            finalRow = i;

            foreach (DataGridViewRow row in ti.DatosRif.Rows)
            {
                ti.mensaje = "Agregando registros" + (p + 1).ToString();
                bw.WorkerReportsProgress = true;
                bw.ReportProgress(p + 1, ti);

                hojaExcel.Cells[i, "A"].NumberFormat = "000000";

                hojaExcel.Cells[i, "A"] = row.Cells[0].Value.ToString();
                hojaExcel.Cells[i, "B"] = row.Cells[1].Value.ToString();
                hojaExcel.Cells[i, "C"] = row.Cells[2].Value.ToString();
                hojaExcel.Cells[i, "D"] = row.Cells[3].Value.ToString();
                hojaExcel.Cells[i, "e"] = row.Cells[4].Value.ToString();

                p++;
                i++;
            }
            ti.mensaje = "Listado RIF generado";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(p, ti);


            hojaExcel.Columns["A:E"].EntireColumn.AutoFit();
            string finalRo;
            finalRo = "L" + i;
            oRange = hojaExcel.Range["E7", finalRo];
            oRange.CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            oRange = hojaExcel.Range["A7", "L7"];
            oRange.Cells.Locked = true;

            oRange = hojaExcel.Range["F8", finalRo];
            oRange.Cells.Locked = false;

            hojaExcel.Protect("vicrif", true);

            string s = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string ruta = s + "\\RIF";

            if (!Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);
            try
            {

                libroExcel.SaveAs(s + @"\RIF\" + ti.CmbEmision + "_" + nombreEmision + " " + ti.cmbOHE + "_" + totalReq + ".xls");
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

            ti.mensaje = "Listo.";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);


        }

        private void _hilo1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                TaskInfo ti = (TaskInfo)e.UserState;
                //Asignamos los máximos de las barras de progreso y los registros a procesar
                pbCarga.Maximum = ti.max;
                //Actualizamos la barra de progreso
                pbCarga.Value = e.ProgressPercentage;
                //Asignamos los datos de la factura
                if (ti.mensaje != "")
                {
                    lblStatus.Text = ti.mensaje;
                }
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }

        private void _hilo1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblStatus.Text = "Proceso completado";
                tsBusqueda.Enabled = true;
                btnExcel.Enabled = true;
                dgAvanceZona.Enabled = true;
                dgRequerimientos.Enabled = true;
                bindingNavigator1.Enabled = true;

            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;

            }
        }

        private void releaseObject(object ob)
        {

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ob);
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

        private void tsBusqueda_Click(object sender, EventArgs e)
        {
            tsBusqueda.SelectAll();
        }
    }
}
