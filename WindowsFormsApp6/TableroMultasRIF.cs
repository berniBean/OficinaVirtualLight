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
        private bool Seleccion = true;

        

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
            cargarAvanceZona();
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

        private void cargarDiasCalendario() 
        {
            foreach (var dia in bdDias.GetDiasFestivos())
            {
                
                monthCalendar1.AddBoldedDate(dia.DiaFeriado);

                
            }
            monthCalendar1.UpdateBoldedDates();
        }
        #region carga de dataGrid de multas
        private void cargarAvanceZona()
        {
            dgMultasPendiente.AutoResizeColumns();
            dgMultasPendiente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            listAvance = obInforme.AvanceMultaSup(idEmision, idSupervisor);//bdAvance.GetAvanceMultaSup(idEmision , idSupervisor);
            listaInformeAvanceBindingSource.DataSource = listAvance;


        }


        private void cargarMultasRIF() 
        {
            listReq = obReq.MultasRIFSup(Convert.ToString(idEmision), OHE);//bdReq.GetMultasRIFSup(Convert.ToString(idEmision), OHE);
            cListaRequeridosBOBindingSource.DataSource = listReq;
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
            cargarDiasCalendario();



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

        private void SetRequeimientoComo(string diligencia)
        {
            tiG.tipoMulta = diligencia;
            int i = 1;
            int total = dgTablaMultasRIF.Rows.Count;

            if (diligencia != "")
                foreach (DataGridViewRow dg in dgTablaMultasRIF.Rows)
                {

                    dg.Cells[8].Value = diligencia;

                    tiG.mensaje = string.Format("procesando...{0}% ", i * 100 / total);
                    backgroundWorker1.ReportProgress(i * 100 / total, tiG);

                    i++;
                }
            pbCarga.Value = 0;
            label1.Text = "Listo.";
            MessageBox.Show("Finalizado");
        }

        private void setTipoMulta(string tipoM)
        {
            if (tipoM != "")
                tipoMulta = tipoM;

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
                    obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
                }
                OHE = dgMultasPendiente.Rows[e.RowIndex].Cells[1].Value.ToString();
                totalReq = dgMultasPendiente.Rows[e.RowIndex].Cells[2].Value.ToString();

                cargarMultasRIF();
                cargarAvanceZona();
            }

        }

        private void dgTablaMultasRIF_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Formatting)
            {
                MessageBox.Show("la fecha debe ser del tipo [dd/mm/aaaa]");
            }
        }
        
        private void ActualizarBD()
        {
            
            for (int i = 0; i < listReq.Count; i++)
            {

                if (listReq[i].Modificado && listReq[i].Estatus != "enviado")
                    obReq.ModificaMultas(listReq[i]);//bdReq.ModificaMultasRif(listReq[i]);
                if (listReq[i].ModificaObservacion)
                    obReq.ObservacionesMultas(listReq[i]);//bdReq.ModificaObservacionesMultasRIF(listReq[i]);

                tiG.mensaje = string.Format("procesando...{0}% ", i * 100 / listReq.Count);
                backgroundWorker1.ReportProgress(i * 100 / listReq.Count, tiG);
            }
            pbCarga.Value = 0;
            label1.Text = "Listo.";
            MessageBox.Show("Guardado completado");
        }


        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            guardar();
            cargarAvanceZona();
            cargarMultasRIF();
        }

        private void guardar()
        {
            //multaVencida();
            MessageBox.Show("TotalReq Actualizados:" + listReq.Count);
            ActualizarBD();
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
                    copiar_portapapeles(dgMultasPendiente);
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
        private void excelEjecucion(Object sender, DoWorkEventArgs e)
        {
            TaskInfo ti = (TaskInfo)e.Argument;
            BackgroundWorker bw = sender as BackgroundWorker;
            CListaRequeridosBO Multa = new CListaRequeridosBO();

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
            hojaExcel.Name = emisionMulta;
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

           
            






            ti.max = Convert.ToInt32(totalReq);
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);

            hojaExcel.Activate();

            Excel.Range oRange;
            Excel.Range objCelda;


            oRange = hojaExcel.Range["A7", "H7"];
            oRange.Interior.ColorIndex = 15;



            


            //referencia general multa RIF [ref_num]
            objCelda = hojaExcel.Range["B1", Type.Missing];
            objCelda.Value = "REF_NUM";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C1", "D1"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            //oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = emisionMulta;


            oRange.Cells.Locked = true;
            //referencia general multa RIF [ZONA]
            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "ZONA";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C2", "D2"];//ZONA
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = lblZonaName;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [OHE]
            objCelda = hojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "OHE";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C3", "D3"];//OHE
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = OHE;
            oRange.Cells.Locked = true;



            //referencia general multa RIF [FECHA EMISIÓN]
            objCelda = hojaExcel.Range["B4", Type.Missing];
            objCelda.Value = "Fecha emisión";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C4", "D4"];//FECHA EMISIÓN
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = e.Result = DateTime.Today;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [TOTAL REQUERIMIENTOS]
            objCelda = hojaExcel.Range["B5", Type.Missing];
            objCelda.Value = "Total requerimientos:";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C5", "D5"];//TOTAL REQUERIMIENTOS
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = ti.DatosRif.Rows.Count;
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
            objCelda.Value = "FECHA DE CITATORIO";

            objCelda = hojaExcel.Range["H7", Type.Missing];
            objCelda.Value = "FECHA DE VENCIMIENTO MULTA";

            int i = 8;
            int p = 0;
            finalRow = i;

            foreach (DataGridViewRow row in ti.DatosRif.Rows)
            {
                ti.mensaje = "Agregando registros" + (p + 1).ToString();
                bw.WorkerReportsProgress = true;
                bw.ReportProgress(p + 1, ti);




                hojaExcel.Cells[i, "B"].NumberFormat = "000000";
                hojaExcel.Cells[i, "G"].NumberFormat = "dd \"de\" mmmm \"de\" aaaa";
                hojaExcel.Cells[i, "H"].NumberFormat = "dd \"de\" mmmm \"de\" aaaa";

                Multa._idMultaRif = row.Cells[0].Value.ToString();
                Multa.Ejecucion = "enviado";

                hojaExcel.Cells[i, "A"] = row.Cells[1].Value.ToString();//tipo multa
                hojaExcel.Cells[i, "B"] = row.Cells[2].Value.ToString();//Número de multa
                hojaExcel.Cells[i, "C"] = row.Cells[3].Value.ToString();//rfc
                hojaExcel.Cells[i, "D"] = row.Cells[4].Value.ToString();//Número de control SAT
                hojaExcel.Cells[i, "e"] = row.Cells[5].Value.ToString();//razón social
                hojaExcel.Cells[i, "F"] = row.Cells[6].Value.ToString();//emisión requerimientos
                hojaExcel.Cells[i, "G"] = Convert.ToDateTime(row.Cells[10].Value.ToString());//fecha notificación
                hojaExcel.Cells[i, "H"] = Convert.ToDateTime(row.Cells[15].Value.ToString());//fecha vencimiento

                //modificar estado a enviado
                //obReq.EjecucionMulta(Multa);

                p++;
                i++;
            }


            ti.mensaje = "Listado RIF generado";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(p, ti);


            hojaExcel.Columns["A:H"].EntireColumn.AutoFit();
            string finalRo;
            finalRo = "N" + i;
            oRange = hojaExcel.Range["H7", finalRo];
            oRange.CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            

            string s = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string ruta = s + "\\RIF";


            if (ti.DatosRif.Rows.Count == 0)
                MessageBox.Show("Sin registros paraenviar");
            else
            {

                if (!Directory.Exists(ruta))
                    Directory.CreateDirectory(ruta);
                try
                {

                    libroExcel.SaveAs(s + @"\RIF\" + "EJECUCION_" + hojaExcel.Name + "_" + OHE + "_" + ti.DatosRif.Rows.Count + ".xlsx");
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

          

            ti.mensaje = "Listo.";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);


        }

        #region "Creacion archivo excel"
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
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;
            hojaExcel.Name = emisionMulta;


            totalReq = Convert.ToString( ti.DatosRif.Rows.Count);

            ti.max = Convert.ToInt32 (totalReq);
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(0, ti);

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
            oRange.Value = emisionMulta;


            oRange.Cells.Locked = true;
            //referencia general multa RIF [ZONA]
            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "ZONA";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C2", "D2"];//ZONA
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = lblZonaName;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [OHE]
            objCelda = hojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "OHE";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C3", "D3"];//OHE
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = OHE;
            oRange.Cells.Locked = true;



            //referencia general multa RIF [FECHA EMISIÓN]
            objCelda = hojaExcel.Range["B4", Type.Missing];
            objCelda.Value = "Fecha emisión";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C4", "D4"];//FECHA EMISIÓN
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = e.Result = fechaMulta;
            oRange.Cells.Locked = true;

            //referencia general multa RIF [TOTAL REQUERIMIENTOS]
            objCelda = hojaExcel.Range["B5", Type.Missing];
            objCelda.Value = "Total requerimientos:";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C5", "D5"];//TOTAL REQUERIMIENTOS
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = ti.DatosRif.Rows.Count;
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
            


            int i = 8;
            int p = 0;
            finalRow = i;

            foreach (DataGridViewRow row in ti.DatosRif.Rows)
            {
                ti.mensaje = "Agregando registros" + (p + 1).ToString();
                bw.WorkerReportsProgress = true;
                bw.ReportProgress(p + 1, ti);

                hojaExcel.Cells[i, "B"].NumberFormat = "000000";
                hojaExcel.Cells[i, "G"].NumberFormat = "000000";


                hojaExcel.Cells[i, "A"] = row.Cells[1].Value.ToString();//tipo multa
                hojaExcel.Cells[i, "B"] = row.Cells[2].Value.ToString();//Número de multa
                hojaExcel.Cells[i, "C"] = row.Cells[3].Value.ToString();//rfc
                hojaExcel.Cells[i, "D"] = row.Cells[4].Value.ToString();//Número de control SAT
                hojaExcel.Cells[i, "e"] = row.Cells[5].Value.ToString();//razón social
                hojaExcel.Cells[i, "F"] = row.Cells[6].Value.ToString();//emisión requerimientos
                hojaExcel.Cells[i, "G"] = row.Cells[7].Value.ToString();//número de requerimiento
                /*hojaExcel.Cells[i, "H"] = row.Cells[8].Value.ToString();//localizado No localizado
                hojaExcel.Cells[i, "I"] = row.Cells[9].Value.ToString();//fecha citatorio
                hojaExcel.Cells[i, "J"] = row.Cells[10].Value.ToString();//fecha notificacion
                hojaExcel.Cells[i, "K"] = row.Cells[11].Value.ToString();//fecha de pago
                hojaExcel.Cells[i, "L"] = row.Cells[12].Value.ToString();//importe*/
                //hojaExcel.Cells[i, "M"] = row.Cells[13].Value.ToString();//cumplió antes
                //hojaExcel.Cells[i, "N"] = row.Cells[15].Value.ToString();//cumplió antes*/



                p++;
                i++;
            }

            
            ti.mensaje = "Listado RIF generado";
            bw.WorkerReportsProgress = true;
            bw.ReportProgress(p, ti);


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
                
                libroExcel.SaveAs(s + @"\RIF\" + tipoMultaEmision + hojaExcel.Name + "_"+ OHE  +"_"+ totalReq + ".xls");
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
                pbCarga.Maximum = ti.DatosRif.Rows.Count;
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
                bindingNavigator1.Enabled = true;
                cargarMultasRIF();


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
        private void tsExcelMultas_Click(object sender, EventArgs e)
        {



            bindingNavigator1.Enabled = false;
            
            try
            {
                BackgroundWorker _hilo1 = new BackgroundWorker();
                _hilo1.DoWork += new DoWorkEventHandler(excelDatos);
                _hilo1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_hilo1_RunWorkerCompleted);
                _hilo1.ProgressChanged += new ProgressChangedEventHandler(_hilo1_ProgressChanged);

                TaskInfo ti = new TaskInfo();
                ti.DatosRif = dgTablaMultasRIF;
                ti.mensaje = "Procesando carga de datos . . .";

                _hilo1.RunWorkerAsync(ti);

            }
            catch (Exception ex)
            {


                lblStatus.Text += ex.Source.ToString() + " - " + ex.Message + "\r\n";

            }
        }








        #endregion
        //listado para ejecución fiscal
        private void tsEjecucionFiscal_Click(object sender, EventArgs e)
        {
            COficioPAEBO pae = new COficioPAEBO();
            listReq = obReq.ListadoEjecucionFiscal(Convert.ToString(idEmision), OHE);//bdReq.GetListadoEjecucionFiscal (Convert.ToString(idEmision), OHE);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            dgTablaMultasRIF.DataSource = cListaRequeridosBOBindingSource;

            
            pae.tipoPAE = 2;
            pae.FechaCreacion = DateTime.UtcNow;
            

            bindingNavigator1.Enabled = false;
            try
            {
                BackgroundWorker _hilo1 = new BackgroundWorker();
                _hilo1.DoWork += new DoWorkEventHandler(excelEjecucion);
                _hilo1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_hilo1_RunWorkerCompleted);
                _hilo1.ProgressChanged += new ProgressChangedEventHandler(_hilo1_ProgressChanged);

                TaskInfo ti = new TaskInfo();
                ti.DatosRif = dgTablaMultasRIF;
                ti.mensaje = "Procesando carga de datos . . .";

                _hilo1.RunWorkerAsync(ti);

            }
            catch (Exception ex)
            {


                lblStatus.Text += ex.Source.ToString() + " - " + ex.Message + "\r\n";

            }

            


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

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TaskInfo tiG = (TaskInfo)e.UserState;
            pbCarga.Value = e.ProgressPercentage;
            label1.Text = tiG.mensaje;
            label1.Update();
        }

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

        private void toolStripTextBusquedaMultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!Modificado())
                    ActualizarBD();
                if (!string.IsNullOrEmpty(toolStripTextBusquedaMultas.Text))
                {

                    busquedaLista();

                }

                else
                    cargarMultasRIF();
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
    }
}
