using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using wpfCreaExcel;
using Excel = Microsoft.Office.Interop.Excel;
using static WindowsFormsApp6.Form4;
using System.IO;
using System.Runtime.InteropServices;
using WindowsFormsApp6.CAD.DAL.factories;
using System.Collections.Generic;
using WindowsFormsApp6.structs;
using System.Linq;
using CleanArchitecture.Helpers;
using System.Threading.Tasks;
using WindowsFormsApp6.Helper;

namespace WindowsFormsApp6
{
    public partial class TableroMultasRIF : Form
    {
        private int idSupervisor;
        private int idEmision;
        private string nomEmision;
        private string lblZonaName;
        private DateTime fechaMulta;
        private string emisionMulta;
        private string origenMultaRIF;
        private string OHE;
        private string ZONA;
        private string totalReq;
        private string referenciaEmision;
        private string nombreEmision;
        private string tipoMulta;
        private DateTime fechaImpresion;
        private int _tipo;
        private bool Seleccion = false;

        

        private CInformeAvance obListaAvance = new CInformeAvance();
        private ListaInformeAvance listAvance;
        obtenerInformes obInforme;
        

        //private ListCoheActivaBLL bdReq = new ListCoheActivaBLL();
        //private CListaRequeridosBO obListaRqe = new CListaRequeridosBO();
        private ListaClistaRequeridos listReq;
        obtenerRequeridos obReq;


        //private CCNombreBimestreBLL bdNombreBim = new CCNombreBimestreBLL();
        private CNombreBimestreBO obListaNomBim = new CNombreBimestreBO();
        private ListaCNombreBimestre listNomBim;

        private CDiasLaboralesBLL bdDias = new CDiasLaboralesBLL();

        private honorarioBLL bdHonorBLL = new honorarioBLL();
        private honorarios oBbdHonor = new honorarios();
        private ListaHonorarios listHonor;

        //actualizar Datos RIF
        private DataSet dsListado = new DataSet();
        private DataTable dt = new DataTable();

        BusquedaDelegado BusquedaMasivaDelegada;
        SetRequerimiento setRequerimientoDelegado;

        SetTipoMulta setTipoMultaDelegada;


        public delegate void ActualizarDelegado();
        public event ActualizarDelegado ejecutar;

        private Excel.PageSetup pageSetup { get; }
        private string tipoMultaEmision;

        obtenerURL obUrl;
        private CListaURL listaUrl;

        TaskInfo tiG = new TaskInfo();


        public TableroMultasRIF(int tipo)
        {

            InitializeComponent();

            toolStripTextBusquedaMultas.CharacterCasing = CharacterCasing.Upper;
            _tipo = tipo;
            if (tipo == 1)
            {
                obInforme = factoryInformes.maker(factoryInformes.RIF);
                obUrl = factoryURL.maker(factoryURL.MRIF);
                tipoMultaEmision = "MRIF_";
                tipoMulta = "ME-RIF-";
            }
            else if(tipo == 2)
            {
                obInforme = factoryInformes.maker(factoryInformes.PLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
                tipoMultaEmision = "MPLUS_";
                tipoMulta = "MI-PLUS";
            }
            BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            setRequerimientoDelegado = new SetRequerimiento(SetRequeimientoComo);
            setTipoMultaDelegada = new SetTipoMulta(setTipoMulta);
            LodadUserDat();
            cargarAvanceZonaAsync().Wait();
            CargarHonor();



            this.dgMultasPendiente.Columns["_totalImporte"].DefaultCellStyle.Format = "C";
            this.dgMultasPendiente.Columns["_honorarios"].DefaultCellStyle.Format = "C";
            this.dgTablaMultasRIF.Columns["Importe"].DefaultCellStyle.Format = "C";
            this.dgTablaMultasRIF.Columns["Honorarios"].DefaultCellStyle.Format = "C";
            btnBusquedaMasiva.Enabled = false;
            tsExcelMultas.Enabled = false;
            toolStripTextBusquedaMultas.Enabled = false;
            guardarToolStripButton.Enabled = false;
            bindingNavigator1.Enabled = false;


        }

        private void CargarHonor() 
        {
            try
            {
                listHonor = bdHonorBLL.getHonorarios(idEmision);

            }
            catch (Exception ex) 
            { 
                
            }
        }

        private async Task cargarDiasCalendarioAsync() 
        {
            var listado = await  bdDias.GetDiasFestivosAsync();
            foreach (var dia in listado)
            {
                
                monthCalendar1.AddBoldedDate(dia.DiaFeriado);

                
            }
            monthCalendar1.UpdateBoldedDates();
        }
        #region carga de dataGrid de multas
        private async Task cargarAvanceZonaAsync()
        {
            dgMultasPendiente.AutoResizeColumns();
            dgMultasPendiente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            listAvance = await obInforme.AvanceMultaSup(idEmision, idSupervisor);//bdAvance.GetAvanceMultaSup(idEmision , idSupervisor);
            listaInformeAvanceBindingSource.DataSource = listAvance;


        }


        private async Task cargarMultasRIFAsync() 
        {
            listReq = await obReq.MultasRIFSup(Convert.ToString(idEmision), OHE);//bdReq.GetMultasRIFSup(Convert.ToString(idEmision), OHE);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
            dgTablaMultasRIF.AutoResizeColumns();
            dgTablaMultasRIF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            if (toolStripTextBusquedaMultas.Enabled == false)
                toolStripTextBusquedaMultas.Enabled = true;
            if (guardarToolStripButton.Enabled == false)
                guardarToolStripButton.Enabled = true;
            if (tsExcelMultas.Enabled == false)
                tsExcelMultas.Enabled = true;
            if (btnBusquedaMasiva.Enabled == false)
                btnBusquedaMasiva.Enabled = true;
            if (bindingNavigator1.Enabled == false)
                bindingNavigator1.Enabled = true;

        }
        #endregion

        //informacion de tablero de multas general
        private void LodadUserDat()
        {

            idSupervisor = CUserLoggin.idUser;
            idEmision = CUserLoggin.idEmision;
            nomEmision = CUserLoggin.nombreEmision;
            lblZonaName = CUserLoggin.zonaSupervisor;
            fechaMulta = CUserLoggin.fechaEmisionMulta;
            emisionMulta = CUserLoggin.nombreEmisionMultaRIF;
            origenMultaRIF = CUserLoggin.origenMultaRIF;
            cargarDiasCalendarioAsync().Wait();



        }

        private ListaClistaRequeridos busqueda(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda)
        {
            ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
            List<CListaRequeridosBO> consulta = new List<CListaRequeridosBO>();

            consulta = (from local in listReq
                        join busqueda in ReturnLstBusqueda on local.NumCtrl equals busqueda.numCtrl
                        where local._tipoMulta.Equals(tipoMulta)
                        select new CListaRequeridosBO()
                        {
                            _idMultaRif = local._idMultaRif,
                            _tipoMulta = local._tipoMulta,
                            _numMulta = local._numMulta,
                            Rfc = local.Rfc,
                            NumCtrl = local.NumCtrl,
                            RazonSocial = local.RazonSocial,
                            _detalleEmision = local._detalleEmision,
                            NumReq = local.NumReq,
                            Diligencia = local.Diligencia,
                            FechaCitatorio = local.FechaCitatorio,
                            FechaNotificacion = local.FechaNotificacion,
                            FechaPago = local.FechaPago,
                            Importe = local.Importe,
                            Honorarios = local.Honorarios,
                            CumplioAntes = local.CumplioAntes,
                            _fechaVencimiento = local._fechaVencimiento,
                            Observaciones = local.Observaciones,
                            Ejecucion = local.Ejecucion,
                            Estatus = local.Estatus
                        }).ToList();
            foreach (var item in consulta)
            {
                if(!listOHE.Contains(new CListaRequeridosBO { NumCtrl = item.NumCtrl }))
                    listOHE.Add(item);
            }
            return listOHE;
        }
        #region busqueda Masiva y delegados
        private void busquedaMasiva(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda)
        {                
            listReq = busqueda(ReturnLstBusqueda);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
            
        }

        private async Task SetRequeimientoComo(string diligencia)
        {
            tiG.tipoMulta = diligencia;
            int i = 1;
            int total = dgTablaMultasRIF.Rows.Count;

            await Task.Run(() =>
            {
                try
                {

                    if (diligencia != "")
                        foreach (DataGridViewRow dg in dgTablaMultasRIF.Rows)
                        {

                            dg.Cells[8].Value = diligencia;

                            tiG.mensaje = string.Format("procesando...{0}% ", i * 100 / total);
                            backgroundWorker1.ReportProgress(i * 100 / total, tiG);

                            i++;
                        }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    pbCarga.Value = 0;
                    label1.Text = "Listo.";
                    MessageBox.Show("Finalizado");
                }
            });



        }

        private async Task setTipoMulta(string tipoM)
        {
            await Task.Run(() =>
            {
                if (tipoM != "")
                    tipoMulta = tipoM;
            });


        }
        #endregion

        #region procesos internos de dgMultasRIF
        private void dgMultasPendiente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            else
            {
                if (_tipo == 1)
                {
                    obReq = factoryRequerimientos.maker(factoryRequerimientos.RIF);
                }
                else if (_tipo == 2)
                {
                    obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS, pbCarga, label1);
                }
                OHE = dgMultasPendiente.Rows[e.RowIndex].Cells[1].Value.ToString();
                totalReq = dgMultasPendiente.Rows[e.RowIndex].Cells[2].Value.ToString();

                cargarMultasRIFAsync().Wait();
                cargarAvanceZonaAsync().Wait();
            }

        }

        private void dgTablaMultasRIF_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Formatting)
            {
                MessageBox.Show("la fecha debe ser del tipo [dd/mm/aaaa]");
            }
        }
        
        private async Task ActualizarBD()
        {

            string TipoDato = "multas";
            ActualizaBDAsync actualizaBD = new ActualizaBDAsync(pbCarga, label1, TipoDato, obReq);
            await actualizaBD.SaveChangesAsync(listReq);

        }


        private async  void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            await guardar();
            cargarAvanceZonaAsync().Wait();
            cargarMultasRIFAsync().Wait();
        }

        private async Task guardar()
        {
            //multaVencida();
           
             await ActualizarBD();
        }



        private void FechaValida(DateTime fechaActual)
        {
            if (fechaActual == Convert.ToDateTime("01/01/0001")) return;

            if (diaNoLaborar(fechaActual))
            {
                dgTablaMultasRIF.CurrentCell.ErrorText = "Este es un día inhábil";
                dgTablaMultasRIF.CurrentCell.Value = null;
            }
            else
            {
                dgTablaMultasRIF.CurrentCell.Value = fechaActual;
                dgTablaMultasRIF.CurrentCell.ErrorText = string.Empty;
            }

        }

        private void dgTablaMultasRIF_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            validarCeldas(sender, e);
           

        }


        private string multaVencida(string diligencia, int importe, DateTime vencimiento) 
        {

            string estatus;
            //importe es cero       notificacion es menor o igual que fecha actual
            if (diligencia == "LOCALIZADO" && importe == 0 && vencimiento <= DateTime.Today)//fecha notificación
                estatus = "vencida";
            else if (diligencia == "LOCALIZADO"  && importe != 0)
                estatus = "pagada";
            else
                
            estatus = "activa";

            return estatus;
        }

        private DateTime plazo45Dias(DateTime fechaNotificacion) 
        {

            DateTime fechaCalculada = Convert.ToDateTime(fechaNotificacion);
            int diasPasados = 0;
            if (FechaNotificacion is null)
                return Convert.ToDateTime( "01/01/0001");
            while (diasPasados <= 30)
            {
                

                if (diaNoLaborar(fechaCalculada))
                {
                    
                    fechaCalculada = fechaCalculada.AddDays(1);
                    
                }
                else 
                {
                    
                    fechaCalculada = fechaCalculada.AddDays(1);
                    diasPasados = diasPasados + 1;
                }
               
                
            }
            fechaCalculada = fechaCalculada.AddDays(-1);
            return fechaCalculada;
        }

        private bool diaNoLaborar(DateTime fechaCalculada)
        {
            bool noLaboral = false;
            foreach (var item in monthCalendar1.BoldedDates)
            {
                if (fechaCalculada.DayOfWeek == DayOfWeek.Saturday || fechaCalculada.DayOfWeek == DayOfWeek.Sunday)
                    return true;
                if (fechaCalculada.Equals(item))
                {
                    noLaboral = true;
                    break;
                }
                    
                
            }
            return noLaboral;
        
        }
        private void validarCeldas(object sender, DataGridViewCellValidatingEventArgs e)
        {
             if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            else
            {
                try
                {
                    switch (dgTablaMultasRIF.Columns[e.ColumnIndex].Name)
                    {



                        case "FechaNotificacion":
                            try
                            {
                                if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) != "")
                                {

                                    if (!this.EsFecha(e.FormattedValue.ToString()))
                                    {
                                        MessageBox.Show("El dato debe ser una fecha tipo dd/mm/aaaa");
                                        dgTablaMultasRIF.CurrentCell.Value = null; return;
                                    }
                                    else
                                        dgTablaMultasRIF.CurrentCell.Value = Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.EditedFormattedValue);
                                    FechaValida(Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.Value));
                                    dgTablaMultasRIF.Rows[e.RowIndex].Cells[15].Value= plazo45Dias(Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.Value));//vencimiento
                                    //ejecucion                                                                 diligencia                                                                  importe                                                                                                   vencimiento
                                    dgTablaMultasRIF.Rows[e.RowIndex].Cells[17].Value = multaVencida(dgTablaMultasRIF.Rows[e.RowIndex].Cells[8].Value.ToString(), Convert.ToInt32(dgTablaMultasRIF.Rows[e.RowIndex].Cells[12].Value.ToString()), Convert.ToDateTime(dgTablaMultasRIF.Rows[e.RowIndex].Cells[15].Value.ToString()));
                                }
                                else if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) == "")
                                {
                                    return;
                                }
                                if (Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.Value) == Convert.ToDateTime("01/01/0001"))
                                    dgTablaMultasRIF.CurrentCell.Value = null; return;
                                break;

                            }
                            catch (FormatException fexcepcion)
                            {

                                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                        case "FechaCitatorio":
                            try
                            {

                                if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) != "")
                                {
                                    if (!this.EsFecha(e.FormattedValue.ToString()))
                                    {
                                        MessageBox.Show("El dato debe ser una fecha tipo dd/mm/aaaa");
                                        dgTablaMultasRIF.CurrentCell.Value = null; return;
                                    }
                                    else
                                        dgTablaMultasRIF.CurrentCell.Value = Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.EditedFormattedValue);
                                    FechaValida(Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.Value));
                                }
                                else if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) == "")
                                {
                                    return;
                                }
                                if (Convert.ToDateTime(dgTablaMultasRIF.CurrentCell.Value) == Convert.ToDateTime("01/01/0001"))
                                    dgTablaMultasRIF.CurrentCell.Value = null; return;
                                break;
                            }
                            catch (FormatException fexcepcion)
                            {
                                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                        case "Importe":
                            dgTablaMultasRIF.CurrentCell.Value = dgTablaMultasRIF.CurrentCell.EditedFormattedValue;
                            if (Convert.ToInt32(dgTablaMultasRIF.CurrentCell.Value.ToString()) == 0)
                            {
                                dgTablaMultasRIF.Rows[e.RowIndex].Cells[13].Value = 0;
                                //dgTablaMultasRIF.Rows[e.RowIndex].Cells[11].Value = null;
                            }
                            else
                                dgTablaMultasRIF.Rows[e.RowIndex].Cells[13].Value = listHonor[0]._honorarios;

                            //ejecucion                                                                 diligencia                                                                  importe                                                                         vencimiento
                            dgTablaMultasRIF.Rows[e.RowIndex].Cells[17].Value = multaVencida(dgTablaMultasRIF.Rows[e.RowIndex].Cells[8].Value.ToString(), Convert.ToInt32(dgTablaMultasRIF.Rows[e.RowIndex].Cells[12].Value.ToString()), Convert.ToDateTime(dgTablaMultasRIF.Rows[e.RowIndex].Cells[15].Value.ToString()));

                            break;


                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Fuera de rango");
                }
            }
        }

        private bool EsFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        private void dgTablaMultasRIF_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgTablaMultasRIF.CurrentCell.ColumnIndex != 8 || dgTablaMultasRIF.CurrentCell.ColumnIndex != 12 || dgTablaMultasRIF.CurrentCell.ColumnIndex != 13)
            {
                try
                {
                    DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

                    dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
                    dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
                }
                catch (InvalidCastException ex)
                {


                }

            }
        }

        private void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgTablaMultasRIF.CurrentCell.ColumnIndex == 8  || dgTablaMultasRIF.CurrentCell.ColumnIndex == 18|| dgTablaMultasRIF.CurrentCell.ColumnIndex == 16)
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == 8 || e.KeyChar == '/' || e.KeyChar == '-')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


            }

        }


        private void btnBusquedaMasiva_Click(object sender, EventArgs e)
        {
            Form4 Ibusqueda = new Form4();

            Ibusqueda.tipoVentana = "Multas";
            Ibusqueda.tipoMulta = tipoMultaEmision; 
            Ibusqueda.setTipoM += new Form4.SetTipoMulta(setTipoMulta);
            Ibusqueda.ejecutar += new Form4.BusquedaDelegado(busquedaMasiva);
            Ibusqueda.setDiligencia += new Form4.SetRequerimiento(SetRequeimientoComo);
            
            Ibusqueda.ShowDialog();
        }



        private void ClearSelection(DataGridView dataGrid)
        {

            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
            {


                cell.Value = "";

            }


        }



        private void busquedaLista()
        {
            listReq = obReq.ListaBusquedaMultasRIF(Convert.ToString(idEmision), OHE, toolStripTextBusquedaMultas.Text);//bdReq.GetListaBusquedaMultasRIF(Convert.ToString(idEmision), OHE, toolStripTextBusquedaMultas.Text);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
        }
        private bool Modificado()
        {
            bool res = true;
            for (int i = 0; i < listReq.Count; i++)
            {
                if (listReq[i].Modificado || listReq[i].ModificaObservacion)
                    res = false;
            }
            return res;

        }
        #endregion


        #region "procedimientos de copiado y pegado"
        private void dgTablaMultasRIF_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyValue == 108 || e.KeyValue == 76) && dgTablaMultasRIF.CurrentCell.ColumnIndex == 8)
                dgTablaMultasRIF.CurrentCell.Value = "LOCALIZADO";
            else if ((e.KeyValue == 110 || e.KeyValue == 78) && dgTablaMultasRIF.CurrentCell.ColumnIndex == 8)
                dgTablaMultasRIF.CurrentCell.Value = "NO LOCALIZADO";

            if (e.KeyValue == 46 && dgTablaMultasRIF.CurrentCell.ReadOnly != true)
            { //suprimir

                if (Seleccion.Equals(false))
                    ClearSelection(dgTablaMultasRIF);
                else
                    MessageBox.Show(string.Format("Para poder borrar celdas con la tecla \"Supr\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                e.Handled = true;

            }

            if (e.KeyValue == 8 && dgTablaMultasRIF.CurrentCell.ReadOnly != true)//retroceso
            {
                e.Handled = true;
                dgTablaMultasRIF.CurrentCell.Value = "";
            }

            if (e.KeyValue == 13 && dgTablaMultasRIF.CurrentCell.ReadOnly != true) //enter
            {


                e.Handled = true;
                dgTablaMultasRIF.BeginEdit(true);


            }

            //funcion de copiado
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (Seleccion.Equals(false))
                {
                    if (dgMultasPendiente.Focused)
                    {
                        copiar_portapapeles(dgMultasPendiente);
                    }
                    else if (dgTablaMultasRIF.Focused)
                    {
                        copiar_portapapeles(dgTablaMultasRIF);
                    }
                }
                    
                else
                    MessageBox.Show(string.Format("Para poder copiar texto con  \"Ctrl + C\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {

                if (Seleccion.Equals(false))
                    pegar_portapapeles(dgTablaMultasRIF);
                else
                    MessageBox.Show(string.Format("Para poder pegar texto con \"Ctrl + v\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                e.Handled = true;



            }

            if (e.Control && e.KeyCode == Keys.F)
            {
                e.Handled = true;
                SeleccionFila(dgTablaMultasRIF);

            }

            if(e.Control && e.KeyCode == Keys.N)
            {
                e.Handled = true;
                SeleccionCeldas(dgTablaMultasRIF);
            }
        }

        private void busqiedaLinQ(string text)
        {
            int totalMultas;

            if (string.IsNullOrEmpty(text))
            {
               dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
            }

            if (text.Equals("PENDIENTE"))
            {
                var consulta = (from item in listReq
                                where item.Estatus.Contains("pendiente")
                                select item).ToList();
                totalMultas = consulta.Count();

                if (totalMultas.Equals(0))
                {
                    MessageBox.Show("No se encontraron datos");
                    return;
                }
                else
                {
                    cListaRequeridosBOBindingSource.DataSource = consulta;
                    dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
                }


            }
            else
            {
                var consulta = (from item in listReq
                                where item.Rfc.Contains(text) ||
                                item.RazonSocial.Contains(text) ||
                                item.NumCtrl.Contains(text)
                                select item).ToList();
                totalMultas = consulta.Count();
                if (totalMultas.Equals(0))
                {
                    MessageBox.Show("No se encontraron datos");
                    return;
                }
                else
                {
                    cListaRequeridosBOBindingSource.DataSource = consulta;
                    dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;
                }
            }

            toolStripTextBusquedaMultas.SelectAll();


        }

        public void copiar_portapapeles(DataGridView dataGrid)
        {
            DataObject objeto_datos = dataGrid.GetClipboardContent();

            Clipboard.SetDataObject(objeto_datos);
        }



        public void pegar_portapapeles(DataGridView datagrid)
        {


            string texto_copiado = Clipboard.GetText();
            string[] lineas = texto_copiado.Split('\n');
            int error = 0;
            int fila = datagrid.CurrentCell.RowIndex;
            int columna = datagrid.CurrentCell.ColumnIndex;
            int tColumna;


            if (lineas.Length == 1 && ColumnasArray(lineas, datagrid, fila, columna, error))
                tColumna = pegarUno(lineas, datagrid, fila, columna, error);
            else
                tColumna = pegado(lineas, datagrid, fila, columna, error);

            //validarFila(columna);





        }

        private bool ColumnasArray(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {
            int indice = 0;
            bool resultado = true;
            DataGridViewCell objeto_celda;
            foreach (string linea in lineas)
            {
                if (fila < datagrid.RowCount && linea.Length > 0)
                {
                    string[] celdas = linea.Split('\t');

                    for (indice = 0; indice < celdas.GetLength(0); ++indice)
                    {
                        if (columna + indice < datagrid.ColumnCount)
                        {
                            objeto_celda = datagrid[columna + indice, fila];

                            //Mientras celda sea Diferente de ReadOnly
                            if (!objeto_celda.ReadOnly)
                            {
                                if (objeto_celda.Value.ToString() != celdas[indice])
                                {

                                    if (celdas[indice] != "\r" && celdas[indice] != "" && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                    {
                                        if (indice > 1)
                                        {
                                            resultado = false;
                                            break;

                                        }
                                    }


                                }
                            }
                            else
                            {
                                // solo intercepta un error si los datos que está pegando es en una celda de solo lectura.
                                error++;
                            }
                        }
                        else
                        { break; }
                    }
                    fila++;
                }
                else
                { break; }

                if (error > 0)

                    MessageBox.Show(string.Format("{0}  La celda no puede ser actualizada, debido a que la configuración de la columna es de solo lectura.", error),
                                              "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return resultado;

        }

        private int pegado(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {
            int indice = 0;
            int carga = 1;

            try
            {
                DataGridViewCell objeto_celda;
                foreach (string linea in lineas)
                {
                    if (fila < datagrid.RowCount && linea.Length > 0)
                    {
                        string[] celdas = linea.Split('\t');

                        for (indice = 0; indice < celdas.GetLength(0); ++indice)
                        {
                            if (columna + indice < datagrid.ColumnCount)
                            {
                                objeto_celda = datagrid[columna + indice, fila];

                                //Mientras celda sea Diferente de ReadOnly
                                if (!objeto_celda.ReadOnly)
                                {
                                    if (objeto_celda.Value.ToString() != celdas[indice])
                                    {
                                        if (celdas[indice] != "\r" && celdas[indice] != "" && celdas[indice] != " " && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                        {

                                            objeto_celda.Value = Convert.ChangeType(celdas[indice], objeto_celda.ValueType);
                                            objeto_celda.Value = objeto_celda.Value.ToString().Trim(new Char[] { '\t', '\n', '\r' });
                                            fechaValidada(objeto_celda);
                                            if (objeto_celda.ColumnIndex == 10)//notificacion
                                            {
                                                dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[15].Value = plazo45Dias(Convert.ToDateTime(objeto_celda.Value));//vencimiento
                                                                            //ejecucion                                                                 diligencia                                                                  importe                                                                                            vencimiento
                                                dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[17].Value = multaVencida(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[8].Value.ToString(), Convert.ToInt32(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[12].Value.ToString()), Convert.ToDateTime(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[15].Value.ToString()));

                                            }
                                            
                                            if(objeto_celda.ColumnIndex==12)//importe
                                            {
                                                dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[13].Value = listHonor[0]._honorarios;
                                                                                //ejecucion                                                                 diligencia                                                                  importe                                                                                              vencimiento
                                                dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[17].Value = multaVencida(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[8].Value.ToString(), Convert.ToInt32(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[12].Value.ToString()), Convert.ToDateTime(dgTablaMultasRIF.Rows[objeto_celda.RowIndex].Cells[15].Value.ToString()));
                                            }


                                            //A continuación la linea añadida para eliminar los '\r'. De paso, y por si acaso en algún contexto ocurre, tambien los: '\t' y '\n'

                                            // Fin linea añadida

                                        }


                                    }

                                }

                                else
                                {
                                    // solo intercepta un error si los datos que está pegando es en una celda de solo lectura.
                                    error++;
                                }
                            }
                            else
                            { break; }
                        }
                        fila++;

                        tiG.mensaje = string.Format("procesando...{0}% ", carga * 100 / lineas.Length);
                        backgroundWorker1.ReportProgress(carga * 100 / lineas.Length, tiG);
                        carga++;
                    }
                    else
                    { break; }

                    if (error > 0)
                        MessageBox.Show(string.Format("{0}  La celda no puede ser actualizada, debido a que la configuración de la columna es de solo lectura.", error),
                                                  "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                pbCarga.Value = 0;
                label1.Text = "Listo.";
                MessageBox.Show("Finalizado");
                return columna;



            }
            catch (FormatException fexcepcion)
            {
                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private int pegarUno(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {

            string[] linea = lineas;
            DateTime fechaActual;

            try
            {

                foreach (DataGridViewCell dg in dgTablaMultasRIF.SelectedCells)
                {

                    if (!dg.ReadOnly)
                    {
                        if (linea[0] != "\r" && linea[0] != "" && linea[0] != "01/01/0001 12:00:00 a. m.")
                            dg.Value = Convert.ChangeType(linea[0], dg.ValueType);
                        if (dg.ColumnIndex == 6 || dg.ColumnIndex == 7)
                        {
                            if (Convert.ToString(dg.EditedFormattedValue) != "")
                            {

                                if (!this.EsFecha(dg.Value.ToString()))
                                {
                                    dg.ErrorText = "Debe ser una fecha tipo dd/mm/aaaa";
                                    dg.Value = null;
                                }
                                else




                                if (Convert.ToDateTime(dg.Value).DayOfWeek == DayOfWeek.Saturday || Convert.ToDateTime(dg.Value).DayOfWeek == DayOfWeek.Sunday)
                                {
                                    dg.ErrorText = "Este es un día inhábil";
                                    dg.Value = null;
                                }
                                else
                                {
                                    dg.Value = dg.Value;
                                    dg.ErrorText = string.Empty;
                                }
                            }
                            else if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) == "")
                            {

                            }
                            if (Convert.ToDateTime(dg.Value) == Convert.ToDateTime("01/01/0001"))
                                dg.Value = null;
                        }

                    }
                    else
                    {
                        error++;
                    }


                }


            }
            catch (FormatException fexcepcion)
            {

                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 1;
            }


            return 1;

        }

        private void fechaValidada(DataGridViewCell objeto_celda)
        {
            if ( objeto_celda.ColumnIndex == 10)
            {
                if (Convert.ToString(objeto_celda.EditedFormattedValue) != "")
                {

                    if (!this.EsFecha(objeto_celda.Value.ToString()))
                    {
                        objeto_celda.ErrorText = "Debe ser una fecha tipo dd/mm/aaaa";
                        objeto_celda.Value = null;
                    }
                    else




                    if (diaNoLaborar(Convert.ToDateTime(objeto_celda.Value)))
                    {
                        objeto_celda.ErrorText = "Este es un día inhábil";
                        objeto_celda.Value = null;
                    }
                    else
                    {
                        objeto_celda.Value = objeto_celda.Value;
                        objeto_celda.ErrorText = string.Empty;
                    }
                }
                else if (Convert.ToString(dgTablaMultasRIF.CurrentCell.EditedFormattedValue) == "")
                {

                }
                if (Convert.ToDateTime(objeto_celda.Value) == Convert.ToDateTime("01/01/0001"))
                    objeto_celda.Value = string.Empty;
            }

        }
        #endregion
        //Archivo ejecucionFiscal


        #region "Creacion archivo excel"


        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = false;

            ExcelDataDto datos = new ExcelDataDto();
            datos.LblEmision = emisionMulta;
            datos.LblZonaName = lblZonaName;
            datos.CmbOHE = OHE;
            datos.FechaEmision = fechaMulta;
            datos.TipoMultaEmision = tipoMultaEmision;

            ToExcelAsync excel = new ToExcelAsync(pbCarga, lblStatus, label1, datos, "MultasConDatos");
            await excel.WriterAsync(listReq);

            bindingNavigator1.Enabled = true;
        }
        private async void tsExcelMultas_Click(object sender, EventArgs e)
        {

            bindingNavigator1.Enabled = false;

            ExcelDataDto datos = new ExcelDataDto();
            datos.LblEmision = emisionMulta;
            datos.LblZonaName = lblZonaName;
            datos.CmbOHE = OHE;
            datos.FechaEmision = fechaMulta;            
            datos.TipoMultaEmision = tipoMultaEmision;

            ToExcelAsync excel = new ToExcelAsync(pbCarga, lblStatus, label1, datos, "MultasSinDatos");
            await excel.WriterAsync(listReq);

            bindingNavigator1.Enabled = true;


        }








        #endregion
        //listado para ejecución fiscal
        private async void tsEjecucionFiscal_Click(object sender, EventArgs e)
        {
            listReq = obReq.ListadoEjecucionFiscal(Convert.ToString(idEmision), OHE);//bdReq.GetListadoEjecucionFiscal (Convert.ToString(idEmision), OHE);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;

            bindingNavigator1.Enabled = false;

            ExcelDataDto datos = new ExcelDataDto();
            datos.LblEmision = emisionMulta;
            datos.LblZonaName = lblZonaName;
            datos.CmbOHE = OHE;
            datos.FechaEmision = fechaMulta;
            datos.TipoMultaEmision = tipoMultaEmision;

            ToExcelAsync excel = new ToExcelAsync(pbCarga, lblStatus, label1, datos, "Ejecucion");
            await excel.WriterAsync(listReq);

            bindingNavigator1.Enabled = true;

        }

        private void TableroMultasRIF_FormClosing(object sender, FormClosingEventArgs e)
        {
            ejecutar();

        }




        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
             Form3 visorImpresor = new Form3();
            visorImpresor.Visible = true;
        }

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    TaskInfo tiG = (TaskInfo)e.UserState;
        //    pbCarga.Value = e.ProgressPercentage;
        //    label1.Text = tiG.mensaje;
        //    label1.Update();
        //}

        private void dgTablaMultasRIF_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                listaUrl = obUrl.listaURI();
                string uri = listaUrl[0]._URL.ToString();
                string tipoM = dgTablaMultasRIF.CurrentRow.Cells[1].Value.ToString();
                string numReq = dgTablaMultasRIF.CurrentRow.Cells[2].Value.ToString();
                string RFC = dgTablaMultasRIF.CurrentRow.Cells[3].Value.ToString();
                string idSAT = dgTablaMultasRIF.CurrentRow.Cells[4].Value.ToString();
                string Rs = dgTablaMultasRIF.CurrentRow.Cells[5].Value.ToString();
                string diligencia = dgTablaMultasRIF.CurrentRow.Cells[8].Value.ToString();
                string citatorio = DateFormatHelper.FechaCorta(Convert.ToDateTime( dgTablaMultasRIF.CurrentRow.Cells[9].Value.ToString()));
                string notificacion = DateFormatHelper.FechaCorta(Convert.ToDateTime(dgTablaMultasRIF.CurrentRow.Cells[10].Value.ToString()));
                string ohe = OHE;
                string emision = Convert.ToString(idEmision);
                int tipo = 1;
                pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, Rs, idSAT, diligencia,citatorio,notificacion, uri, emision, ohe);
                vistaPDf.ShowDialog();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void SeleccionFila(DataGridView dataGrid)
        {
            Seleccion = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SeleccionCeldas(DataGridView dataGrid)
        {
            Seleccion = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void toolStripTextBusquedaMultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (Modificado())
                    ActualizarBD().Wait();

                if (!string.IsNullOrEmpty(toolStripTextBusquedaMultas.Text))
                {
                    busqiedaLinQ(toolStripTextBusquedaMultas.Text);
                }
                else
                {
                    //cargarAvanceZona();
                    cargarMultasRIFAsync().Wait();
                }

            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableroMultasRIF_Load(object sender, EventArgs e)
        {
            dgTablaMultasRIF.AllowUserToResizeColumns = true;
            dgTablaMultasRIF.ColumnHeaderMouseDoubleClick += dgTablaMultasRIF_ColumnHeaderMouseDoubleClick;

        }

        private void dgTablaMultasRIF_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex != -1)
            {
                dgTablaMultasRIF.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in dgTablaMultasRIF.Columns)
            {
                if (!item.Visible)
                {
                    if(!(item.DataPropertyName.Equals("_idMultaRif")|| item.DataPropertyName.Equals("CumplioAntes")
                        || item.DataPropertyName.Equals("ModificaFechaPago") 
                        ||item.DataPropertyName.Equals("ModificaObservacion")
                        || item.DataPropertyName.Equals("Modificado")))
                    item.Visible = true;
                }
            }
        }
    }
}
