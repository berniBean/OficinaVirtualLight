using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp6.BLL;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories; 
using wpfCreaExcel;
using static WindowsFormsApp6.Form4;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp6.structs;
using CleanArchitecture.Helpers;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private Login lg = new Login();
        private int datoID;
        private string temp;
        private int _tipo;
        private bool seleccion = true;
        
        

        BusquedaDelegado BusquedaMasivaDelegada;
        SetRequerimiento setRequerimientoDelegado;      

        SetFecha SetFechaDelegado;


        private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        private CanhoFiscalBO obListaAnho = new CanhoFiscalBO();
        obtenerPeriodoFiscal obListYear;

        //obtenerPeriodoFiscal obListYear =  factoryYear.maker(factoryYear.RIF
        /// <summary>
        /// 
        /// </summary>
        //private CEmisionActualBLL bdPeriodo = new CEmisionActualBLL();
        private CEmisionActualBO obListadoPeriodo = new CEmisionActualBO();
        private ListCEmisionActual listPeriodo;
        obtenerEmision obEmision;

        //private CoheActivaBLL bdOHE = new CoheActivaBLL();
        private CoheActivaBO obListadoOHE = new CoheActivaBO();
        private ListCoheActiva listOHE;
        obtenerOHE obOHE;

        //private CCNombreBimestreBLL bdNombreBim = new CCNombreBimestreBLL();
        private CNombreBimestreBO obListaNomBim = new CNombreBimestreBO();
        private ListaCNombreBimestre listNomBim;
        obtenerNombreBimestre obNomBimestre;

        //actualizar Datos RIF
        //private ListCoheActivaBLL bdReq = new ListCoheActivaBLL();
        obtenerRequeridos  obReq;
        //private CListaRequeridosBO obListaRqe = new CListaRequeridosBO();
        private ListaClistaRequeridos listReq;
        private CListNotificadores listNotificador;
        private CListaCatObservaciones ListaObservaciones;
        private DataSet dsListado = new DataSet();
        private DataTable dt = new DataTable();

        private CDiasLaboralesBLL bdDias = new CDiasLaboralesBLL();
        private CNotificadoresDAL CatalogoNotificadores = new CNotificadoresDAL();
        private CatObservacionesDAL catalogo = new CatObservacionesDAL();


        TaskInfo tiG = new TaskInfo();

        obtenerURL obUrl;
        private CListaURL listaUrl;

       
        public Form1(int tipo)
        {
            

            InitializeComponent();

            

            toolStripTextBusqueda.CharacterCasing = CharacterCasing.Upper;
            if (tipo == 1)
            {
                obListYear = factoryYear.maker(factoryYear.RIF);
                obEmision = factoryEmision.maker(factoryEmision.RIF);
                obOHE = factoryOHE.maker(factoryOHE.RIF);
                obNomBimestre = factoryNombreBimestre.maker(factoryNombreBimestre.RIF);
                obReq = factoryRequerimientos.maker(factoryRequerimientos.RIF);
                obUrl = factoryURL.maker(factoryURL.RIF);

            }
            else if (tipo == 2)
            {
                obListYear = factoryYear.maker(factoryYear.PLUS);
                obEmision = factoryEmision.maker(factoryEmision.PLUS);
                obOHE = factoryOHE.maker(factoryOHE.PLUS);
                obNomBimestre = factoryNombreBimestre.maker(factoryNombreBimestre.PLUS);
                obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
                obUrl = factoryURL.maker(factoryURL.PLUS);
            }
            
            BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            setRequerimientoDelegado = new SetRequerimiento(SetRequeimientoComo);
            SetFechaDelegado = new SetFecha(SetFechaComo);
            btnGuardar.Enabled = false;
            btnExcel.Enabled = false;
            btnBusquedaMasiva.Enabled = false;
            //toolStripTextBusqueda.Enabled = false;
            guardarToolStripButton.Enabled = false;
            _tipo = tipo;


        }



        public Form1()
        {
           /* InitializeComponent();            
            BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            setRequerimientoDelegado = new SetRequerimiento(SetRequeimientoComo);
            SetFechaDelegado = new SetFecha(SetFechaComo);
            btnGuardar.Enabled = false;
            btnExcel.Enabled = false;
            btnBusquedaMasiva.Enabled = false;
            toolStripTextBusqueda.Enabled = false;
            guardarToolStripButton.Enabled = false;*/
            

        }


        private void cargarDiasCalendario()
        {
            foreach (var dia in bdDias.GetDiasFestivos())
            {

                monthCalendar1.AddBoldedDate(dia.DiaFeriado);


            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.DgReqActivos2.DataError +=
                new DataGridViewDataErrorEventHandler(DgReqActivos_DataError);

            LodadUserDat();
            CargarAnho();
            CargarPeriodo();
            CargarOHE();
            CargarNombreBimestre();
            DgReqActivos2.ReadOnly = false;
            cargarDiasCalendario();


            


        }

        private void DgReqActivos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Formatting)
            {
                MessageBox.Show("la fecha debe ser del tipo [dd/mm/aaaa]");
            }
        }

        /// carga de los datos de parametros de seleccion
        //se realiza la carga de los años activos
        private void CargarAnho()
        {
            try
            {
                //origen de los datos
                canhoFiscalBOBindingSource.DataSource = obListYear.listadoAños();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Realiza la carga de las emisiones totales
        private void CargarPeriodo()
        {
            try
            {
                //origen de los datos
                listPeriodo = obEmision.listadoEmisiones(cmbAnho.Text);
                listCEmisionActualBindingSource.DataSource = listPeriodo;
           


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Realiza la carga de las oficinas activas en el periodo
        private void CargarOHE()
        {
            
            try
            {
                listOHE = obOHE.listadosOHE(Convert.ToString(datoID), lblEmision.Text); //bdOHE.GetOHE(Convert.ToString(datoID), lblEmision.Text);
                coheActivaBOBindingSource.DataSource = listOHE;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarNombreBimestre() {

            try
            {

                listNomBim = obNomBimestre.ListNombreBimestre(lblEmision.Text, cmbOHE.Text);//bdNombreBim.GetNombreEmision(lblEmision.Text, cmbOHE.Text);
                cNombreBimestreBOBindingSource.DataSource = listNomBim;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarRequerimientos()
        {


            
            

            if (btnGuardar.Enabled == false)
                btnGuardar.Enabled = true;
            if (btnExcel.Enabled == false)
                btnExcel.Enabled = true;
            if (btnBusquedaMasiva.Enabled == false)
                btnBusquedaMasiva.Enabled = true;
            
                
            if (guardarToolStripButton.Enabled == false)
                guardarToolStripButton.Enabled = true;

            cargaRequerimientos();
        }

        private void LodadUserDat()
        {
            lblZonaName.Text = CUserLoggin.zonaSupervisor;
            datoID = CUserLoggin.idUser;

        }
        /// carga de los datos de parametros de seleccion

        //Sección de control de eventos leave y carga de menús de selección


        private void CmbAnho_Leave(object sender, EventArgs e)
        {
            
            CargarPeriodo();
            CargarOHE();
            CargarRequerimientos();
            CargarNombreBimestre();
            DgReqActivos2.AutoResizeColumns();
            DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void cmbAnho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //enter
            {
                CargarPeriodo();
                CargarOHE();
                CargarRequerimientos();
                CargarNombreBimestre();
                DgReqActivos2.AutoResizeColumns();
                DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }

        private void CmbEmision_Leave(object sender, EventArgs e)
        {
            CargarOHE();
            CargarRequerimientos();
            CargarNombreBimestre();
            DgReqActivos2.AutoResizeColumns();
            DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cmbEmision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CargarOHE();
                CargarRequerimientos();
                CargarNombreBimestre();
                DgReqActivos2.AutoResizeColumns();
                DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

        }

        private void CmbOHE_Leave_1(object sender, EventArgs e)
        {
            CargarRequerimientos();
            CargarNombreBimestre();
            DgReqActivos2.AutoResizeColumns();
            DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cmbOHE_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyValue == 13)
            {
                CargarRequerimientos();
                CargarNombreBimestre();
                DgReqActivos2.AutoResizeColumns();
                DgReqActivos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DgReqActivos2.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void ActualizarBD()
        {

            for (int i = 0; i < listReq.Count; i++)
            {
                if (listReq[i].Modificado && listReq[i].Estatus != "enviado")
                    obReq.ModificarRequerimientos(listReq[i]);//bdReq.ModificarFechasRIF(listReq[i]);
                if (listReq[i].ModificaObservacion || listReq[i].ModificaMalCapturado)
                    obReq.ObservacionesRequerimientos(listReq[i]);//bdReq.ModificarObservacionesRIF(listReq[i]);




                //backgroundWorker1.ReportProgress(i * 100 / listReq.Count);
                //lblStatus.Text = Convert.ToString(i * 100 / listReq.Count);

                tiG.mensaje = string.Format("procesando...{0}% ", i * 100 / listReq.Count);
                backgroundWorker1.ReportProgress(i * 100 / listReq.Count, tiG);
            }
            pbCarga.Value = 0;
            lblListo.Text = "Listo.";
            MessageBox.Show("Guardado completado");

            
        }


        //Método para ejecutar la acción guardar
        private  void BtnGuardar_Click(object sender, EventArgs e)
        {
            //validarColumna();
              guardar();
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
           
            MessageBox.Show("TotalReq Actualizados:" + listReq.Count);
            ActualizarBD();
            CargarRequerimientos();
        }



        private void FechaValida(DateTime fechaActual)
        {
            if (fechaActual == Convert.ToDateTime("01/01/0001")) return;
            if (fechaActual < Convert.ToDateTime(FechaImpresion.Text))
            {
                DgReqActivos2.CurrentCell.ErrorText = "la Notificacion no puede ser menor a la fecha de Impresion";
                DgReqActivos2.CurrentCell.Value = null;
                return;
            }

            if (fechaActual >= DateTime.Now)
            {
                DgReqActivos2.CurrentCell.ErrorText = "la Notificacion no puede ser mayor a la fecha actual";
                DgReqActivos2.CurrentCell.Value = null;
                return;
            }


            if (diaNoLaborar(fechaActual))
            {
                DgReqActivos2.CurrentCell.ErrorText = "No debe ser un día inhábil";
                DgReqActivos2.CurrentCell.Value = null;
            }
            else
            {
                DgReqActivos2.CurrentCell.Value = fechaActual;
                DgReqActivos2.CurrentCell.ErrorText = string.Empty;
            }

        }

        

        
        private void DgReqActivos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            validarCeldas(sender, e);
           
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
                    switch (DgReqActivos2.Columns[e.ColumnIndex].Name)
                    {



                        case "FechaNotificacion":
                            try
                            {
                                if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) != "")
                                {

                                    if (!this.EsFecha(e.FormattedValue.ToString()))
                                    {
                                        MessageBox.Show("El dato debe ser una fecha tipo dd/mm/aaaa");
                                        DgReqActivos2.CurrentCell.Value = null; return;
                                    }
                                    else
                                    DgReqActivos2.CurrentCell.Value = Convert.ToDateTime(DgReqActivos2.CurrentCell.EditedFormattedValue);                                   
                                    FechaValida(Convert.ToDateTime(DgReqActivos2.CurrentCell.Value));
                                }
                                else if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) == "")
                                {
                                    return;
                                }
                                if (Convert.ToDateTime(DgReqActivos2.CurrentCell.Value) == Convert.ToDateTime("01/01/0001"))
                                    DgReqActivos2.CurrentCell.Value = null; return;
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
                                
                                if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) != "")
                                {
                                    if (!this.EsFecha(e.FormattedValue.ToString()))
                                    {
                                        MessageBox.Show("El dato debe ser una fecha tipo dd/mm/aaaa");
                                        DgReqActivos2.CurrentCell.Value = null; return;
                                    }
                                    else
                                        DgReqActivos2.CurrentCell.Value = Convert.ToDateTime(DgReqActivos2.CurrentCell.EditedFormattedValue);
                                    FechaValida(Convert.ToDateTime(DgReqActivos2.CurrentCell.Value));
                                }
                                else if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) == "")
                                {
                                    return;
                                }
                                if (Convert.ToDateTime(DgReqActivos2.CurrentCell.Value) == Convert.ToDateTime("01/01/0001"))
                                    DgReqActivos2.CurrentCell.Value = null; return;
                                break;
                            }
                            catch (FormatException fexcepcion)
                            {
                                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                        case "FechaEnvio":
                            try
                            {
                                if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) != "")
                                {
                                    if (!this.EsFecha(e.FormattedValue.ToString()))
                                    {
                                        MessageBox.Show("El dato debe ser una fecha tipo dd/mm/aaaa");
                                        DgReqActivos2.CurrentCell.Value = null; return;
                                    }
                                    else
                                        DgReqActivos2.CurrentCell.Value = Convert.ToDateTime(DgReqActivos2.CurrentCell.EditedFormattedValue);
                                    FechaValida(Convert.ToDateTime(DgReqActivos2.CurrentCell.Value));
                                }
                                else if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) == "")
                                {
                                    return;
                                }
                                if (Convert.ToDateTime(DgReqActivos2.CurrentCell.Value) == Convert.ToDateTime("01/01/0001"))
                                    DgReqActivos2.CurrentCell.Value = null; return;
                                break;

                            }
                            catch (FormatException fexcepcion)
                            {
                                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }



                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Fuera de rango"); 
                }
            }
        }

     


        private void toolStripTextBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                if (!Modificado())
                    ActualizarBD();
                if (!string.IsNullOrEmpty(toolStripTextBusqueda.Text))
                {

                    busquedaLista();

                }

                else
                    cargaRequerimientos();
            }

        }

        private void SeleccionFila(DataGridView dataGrid)
        {
            seleccion = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SeleccionCeldas(DataGridView dataGrid)
        {
            seleccion = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        private void ClearSelection(DataGridView dataGrid)
        {

            
            int i = 1;
            int total = DgReqActivos2.Rows.Count;           
            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
                {

                   
                cell.Value = "";
                tiG.mensaje = string.Format("procesando...{0}% ", i * 100 / total);
                backgroundWorker1.ReportProgress(i * 100 / total, tiG);

                i++;
            }
            pbCarga.Value = 0;
            lblListo.Text = "Listo.";
            MessageBox.Show("Finalizado");

        }

        //verifica las acciones de copiar pegar enter suprimir y borrar
        private  void DgReqActivos_KeyDown(object sender, KeyEventArgs e)
        {



            if ((e.KeyValue == 108 || e.KeyValue == 76) && DgReqActivos2.CurrentCell.ColumnIndex == 5)
                DgReqActivos2.CurrentCell.Value = "LOCALIZADO";
            else if ((e.KeyValue == 110 || e.KeyValue == 78) && DgReqActivos2.CurrentCell.ColumnIndex == 5)
                DgReqActivos2.CurrentCell.Value = "NO LOCALIZADO";

            
            
            //funcion de copiado
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (seleccion.Equals(false))
                    copiar_portapapeles(DgReqActivos2);
                else
                    MessageBox.Show(string.Format("Para poder copiar texto con  \"Ctrl + C\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                if (seleccion.Equals(false))
                    pegar_portapapeles(DgReqActivos2);
                else
                    MessageBox.Show(string.Format("Para poder pegar texto con \"Ctrl + v\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                e.Handled = true;
                



            }


            if (e.KeyValue == 46 && DgReqActivos2.CurrentCell.ReadOnly != true)
            { //suprimir

                if(seleccion.Equals(false))
                    ClearSelection(DgReqActivos2);
                else
                    MessageBox.Show(string.Format("Para poder borrar celdas con la tecla \"Supr\" debe presionar \"Ctrl + n\" primero."),
                          "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                e.Handled = true;

            }




            if (e.KeyValue == 8 && DgReqActivos2.CurrentCell.ReadOnly != true)//retroceso
            {
                e.Handled = true;
                DgReqActivos2.CurrentCell.Value = "";
            }

            if (e.KeyValue == 13 && DgReqActivos2.CurrentCell.ReadOnly != true) //enter
            {

                e.Handled = true;
                DgReqActivos2.BeginEdit(true);


            }



            if (e.Control && e.KeyCode == Keys.F)
            {
                e.Handled = true;
                SeleccionFila(DgReqActivos2);

            }

            if(e.Control && e.KeyCode == Keys.N)
            {
                e.Handled = true;
                SeleccionCeldas(DgReqActivos2);
            }


        }

        private void _hiloPegar_rogressChanged(object sender, ProgressChangedEventArgs e)
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

        private void _hiloPegar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblStatus.Text = "Proceso completado";


            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;

            }
        }


        #region "copiar y pegar"
        //funcion de copiado 
        public void copiar_portapapeles(DataGridView dataGrid) {
            DataObject objeto_datos = dataGrid.GetClipboardContent();

            Clipboard.SetDataObject(objeto_datos);
        }

        public void pegar_arreglo(string[] contenido)
        {
            string texto_copiado = Clipboard.GetText();
            string[] lineas = texto_copiado.Split('\n');
            int error = 0;
           //int fila = datagrid.CurrentCell.RowIndex;
           //int columna = datagrid.CurrentCell.ColumnIndex;
            int tColumna;

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
                tColumna= pegarUno(lineas, datagrid, fila, columna, error);
            else
                tColumna= pegado(lineas, datagrid, fila, columna, error);

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




        private void fechaValidada(DataGridViewCell objeto_celda)
        {
            if (objeto_celda.ColumnIndex == 6 || objeto_celda.ColumnIndex == 7)
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
                else if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) == "")
                {

                }
                if (Convert.ToDateTime(objeto_celda.Value) == Convert.ToDateTime("01/01/0001"))
                    objeto_celda.Value = string.Empty;
            }
        
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

        private int pegado(string[] lineas, DataGridView datagrid, int fila, int columna, int error)
        {
            int indice=0;
            int carga = 1;
            try {
                DataGridViewCell objeto_celda;
                foreach (string linea in lineas)
                {
                    if (fila < datagrid.RowCount && linea.Length > 0)
                    {
                        string[] celdas = linea.Split('\t');

                        for ( indice = 0; indice < celdas.GetLength(0); ++indice)
                        {
                            if (columna + indice < datagrid.ColumnCount)
                            {
                                objeto_celda = datagrid[columna + indice, fila];
                                
                                //Mientras celda sea Diferente de ReadOnly
                                if (!objeto_celda.ReadOnly)
                                {
                                    if (objeto_celda.Value.ToString() != celdas[indice])
                                    {
                                        if (celdas[indice] != "\r"&& celdas[indice] !="" && celdas[indice] != " " && celdas[indice] != "01/01/0001 12:00:00 a. m.")
                                        {

                                            objeto_celda.Value = Convert.ChangeType(celdas[indice], objeto_celda.ValueType);
                                            objeto_celda.Value = objeto_celda.Value.ToString().Trim(new Char[] { '\t', '\n', '\r' });
                                            fechaValidada(objeto_celda);
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
                        //backgroundWorker1.ReportProgress(carga * 100 / lineas.Length);
                        //lblStatus.Text = Convert.ToString(carga * 100 / lineas.Length);
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
                lblListo.Text = "Listo.";
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
                
                foreach (DataGridViewCell dg in DgReqActivos2.SelectedCells)
                {

                    if (!dg.ReadOnly)
                    {
                        if(linea[0] != "\r" && linea[0] != "" && linea[0] != "01/01/0001 12:00:00 a. m.")
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
                                    dg.ErrorText = "No debe ser fin de semana";
                                    dg.Value = null;
                                }
                                else
                                {
                                    dg.Value = dg.Value;
                                    dg.ErrorText = string.Empty;
                                }
                            }
                            else if (Convert.ToString(DgReqActivos2.CurrentCell.EditedFormattedValue) == "")
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
        #endregion



        private void busquedaLista()
        {
            listReq = obReq.ListaBusqueda(lblEmision.Text, cmbOHE.Text, toolStripTextBusqueda.Text);//bdReq.GetListaBusqueda(lblEmision.Text, cmbOHE.Text,toolStripTextBusqueda.Text);
            cListaRequeridosBOBindingSource.DataSource = listReq;
            DgReqActivos2.DataSource = cListaRequeridosBOBindingSource;
        }



        private  void busquedaMasiva(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda)
        {
            ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
            List<CListaRequeridosBO> consulta = new List<CListaRequeridosBO>();

            
               consulta = (from local in listReq
                                join busqueda in ReturnLstBusqueda on local.NumCtrl equals busqueda.numCtrl
                                select new CListaRequeridosBO()
                                {
                                    NumReq = local.NumReq,
                                    Rfc = local.Rfc,
                                    NumCtrl = local.NumCtrl,
                                    RazonSocial = local.RazonSocial,
                                    Localidad = local.Localidad,
                                    Diligencia = local.Diligencia,
                                    FechaNotificacion = local.FechaNotificacion,
                                    FechaCitatorio = local.FechaCitatorio,
                                    OficioSEFIPLAN = local.OficioSEFIPLAN,
                                    FechaEntregaNotificador = local.FechaEntregaNotificador,
                                    FechaEnvioSefiplan = local.FechaEnvioSefiplan,
                                    FechaRecepcion = local.FechaRecepcion,
                                    Estatus = local.Estatus,
                                    NombreNotificador = local.NombreNotificador,
                                    Observaciones = local.Observaciones
                                }).ToList();
            


            foreach (var item in consulta)
            {
                if(!listOHE.Contains(new CListaRequeridosBO { NumCtrl = item.NumCtrl}))
                    listOHE.Add(item);
            }
            listReq = listOHE;
            cListaRequeridosBOBindingSource.DataSource = listReq;
            DgReqActivos2.DataSource = cListaRequeridosBOBindingSource;
            

        }


        private void cargaRequerimientos()
        {
            ListaObservaciones = catalogo.GetCatObservacion();
            listNotificador = CatalogoNotificadores.GetNotificadorSupervisor(datoID);
            Cache.CUserLoggin.Notificadores = listNotificador;
            listReq = obReq.Requerimientos(lblEmision.Text, cmbOHE.Text);//bdReq.GatReqGetRequerimientos(lblEmision.Text, cmbOHE.Text);



            cListaCatObservacionesBindingSource.DataSource = ListaObservaciones;
            cListaRequeridosBOBindingSource.DataSource = listReq;
            DgReqActivos2.DataSource = cListaRequeridosBOBindingSource;

        }

        private bool Modificado()
        {
            bool res = true;
            for (int i = 0; i < listReq.Count; i++)
            {
                if (listReq[i].Modificado || listReq[i].ModificaObservacion||listReq[i].MalCapturado||listReq[i].ActaCitatorio||listReq[i].ActaNotificacion||listReq[i].NotificacionCitatorio)
                    res = false;
            }
            return res;

        }

        #region "crear archivo Excel"

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
            hojaExcel.Name = groupBox2.Text;
            hojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;



            ti.max = listNomBim[0].Total;
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
            oRange.Value = listNomBim[0].NombreEmision;


            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B2", Type.Missing];
            objCelda.Value = "ZONA";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C2", "D2"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = lblZonaName.Text;
            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "OHE";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C3", "D3"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = ti.cmbOHE;
            oRange.Cells.Locked = true;




            objCelda = hojaExcel.Range["B4", Type.Missing];
            objCelda.Value = "Fecha emisión";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C4", "D4"];//ref_num
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.NumberFormat = "dd \"de\" mmmm \"de\" yyyy";
            oRange.Value = e.Result = listNomBim[0].FechaEmision;
            oRange.Cells.Locked = true;

            objCelda = hojaExcel.Range["B5", Type.Missing];
            objCelda.Value = "Total requerimientos:";
            oRange.Cells.Locked = true;
            oRange = hojaExcel.Range["C5", "D5"];
            oRange.Merge(true);
            oRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oRange.Value = listNomBim[0].Total;
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

                libroExcel.SaveAs(s + @"\RIF\" + ti.CmbEmision + "_" + hojaExcel.Name + " " + ti.cmbOHE + "_" + listNomBim[0].Total.ToString() + ".xls");
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
                cmbAnho.Enabled = true;
                CmbEmision.Enabled = true;
                cmbOHE.Enabled = true;
                btnGuardar.Enabled = true;
                btnExcel.Enabled = true;
                DgReqActivos2.Enabled = true;
                bindingNavigator1.Enabled = true;

            }
            catch (Exception ex)
            {

                        lblStatus.Text = ex.Message;

            }
        }

        private void releaseObject(object ob) {

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ob);
                ob = null;
            }
            catch (Exception ex)
            {

                ob = null;
                MessageBox.Show("Error al liberar"+ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        //crear archivo de excel con hilo de ejecucion 1
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cmbAnho.Enabled = false;
            CmbEmision.Enabled = false;
            cmbOHE.Enabled = false;

            btnGuardar.Enabled = false;
            btnExcel.Enabled = false;
            DgReqActivos2.Enabled = false;
            bindingNavigator1.Enabled = false;
            try
            {
                BackgroundWorker _hilo1 = new BackgroundWorker();
                _hilo1.DoWork += new DoWorkEventHandler(excelDatos);
                _hilo1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_hilo1_RunWorkerCompleted);
                _hilo1.ProgressChanged += new ProgressChangedEventHandler(_hilo1_ProgressChanged);

                TaskInfo ti = new TaskInfo();
                
                ti.cmbOHE = cmbOHE.Text;
                ti.CmbEmision = lblEmision.Text;
                ti.DatosRif = DgReqActivos2;
                ti.mensaje = "Procesando carga de datos . . .";

                _hilo1.RunWorkerAsync(ti);

            }
            catch (Exception ex)
            {


                lblStatus.Text += ex.Source.ToString() + " - " + ex.Message + "\r\n";

            }
        }
        #endregion

        private Boolean EsFecha(string fecha)
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

        private void DgReqActivos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colIndex = DgReqActivos2.CurrentCell.ColumnIndex;
            var colName = DgReqActivos2.Columns[colIndex].Name;

            if(colName == "NombreNotificador")
            {
                TextBox textBox = (TextBox)e.Control;
                textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox.AutoCompleteCustomSource = GetSuggestName("NombreNotificador");
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            

            if (DgReqActivos2.CurrentCell.ColumnIndex != 5 || DgReqActivos2.CurrentCell.ColumnIndex != 8 )
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

        private AutoCompleteStringCollection GetSuggestName(string Columna)
        {
            string[] s;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            if (Columna == "NombreNotificador")
            {
                

                var query = listNotificador.Select(element => new
                {
                    element.IdNotificador,
                    element.ConcatenadoNotificador,
                   
                }).OrderBy(x => x.IdNotificador);
                s = query.Select(p => p.ConcatenadoNotificador).ToArray();
                
                collection.AddRange(s);
                
            }





             


            return collection;
        }

        private void dText_KeyPress(object sender, KeyPressEventArgs e)
       {
            var colIndex = DgReqActivos2.CurrentCell.ColumnIndex;
            var colName = DgReqActivos2.Columns[colIndex].Name;
            
            if (colName== "ActaNotificacion" || colName == "ActaCitatorio" || colName == "NotificacionCitatorio" 
                || colName == "Diligencia" || colName == "NombreNotificador" || colName == "Observaciones" || colName == "NotasObservaciones")
            {
                e.Handled = false;
            }
            else {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == 8 || e.KeyChar == '/'||e.KeyChar=='-')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


            }

        }



        //listPeriodo[0].NomEmision.ToString();
        private void DgReqActivos2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                listaUrl = obUrl.listaURI();
                string uri = listaUrl[0]._URL.ToString();
                string numReq = DgReqActivos2.CurrentRow.Cells[0].Value.ToString();
                string RFC = DgReqActivos2.CurrentRow.Cells[1].Value.ToString();
                string idSAT = DgReqActivos2.CurrentRow.Cells[2].Value.ToString();
                string rs = DgReqActivos2.CurrentRow.Cells[3].Value.ToString();
                string diligencia =  DgReqActivos2.CurrentRow.Cells[5].Value.ToString();
                string Citatorio = DateFormatHelper.FechaCorta(Convert.ToDateTime(DgReqActivos2.CurrentRow.Cells[6].Value.ToString())) ;
                string Notificacion = DateFormatHelper.FechaCorta(Convert.ToDateTime(DgReqActivos2.CurrentRow.Cells[7].Value.ToString()));
                string ohe = cmbOHE.Text;
                string emision = lblEmision.Text;
                int tipo = 1;
                pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, rs, idSAT, diligencia,Citatorio,Notificacion, uri, emision, ohe);
                vistaPDf.ShowDialog();
            }
        }

        private void DgReqActivos2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DatoCTRL.Text = DgReqActivos2.CurrentRow.Cells[2].Value.ToString();
            DatoRS.Text = DgReqActivos2.CurrentRow.Cells[3].Value.ToString();
            DatoEstatus.Text = DgReqActivos2.CurrentRow.Cells[13].Value.ToString();
            DatoObservaciones.Text = DgReqActivos2.CurrentRow.Cells[18].Value.ToString();

            
        }

        private void DgReqActivos2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            DatoCTRL.Text = DgReqActivos2.CurrentRow.Cells[2].Value.ToString();
            DatoRS.Text = DgReqActivos2.CurrentRow.Cells[3].Value.ToString();
            DatoEstatus.Text = DgReqActivos2.CurrentRow.Cells[13].Value.ToString();
            DatoObservaciones.Text = DgReqActivos2.CurrentRow.Cells[18].Value.ToString();

        }

        private void btnBusquedaMasiva_Click(object sender, EventArgs e)
        {
            Form4 Ibusqueda = new Form4();
            Ibusqueda.tipoVentana = "Requerimientos";
            Ibusqueda.ejecutar += new Form4.BusquedaDelegado(busquedaMasiva);
            Ibusqueda.setDiligencia += new Form4.SetRequerimiento(SetRequeimientoComo);
            Ibusqueda.setFechaReq += new Form4.SetFecha(SetFechaComo);
            Ibusqueda.ShowDialog();

        }

        private void SetFechaComo(DateTime fecha)
        {

          


        }


        private void SetRequeimientoComo(string diligencia)
        {
            
            tiG.tipoMulta = diligencia;
            int i = 1;
            int total = DgReqActivos2.Rows.Count;
            if (diligencia != "")

                foreach (DataGridViewRow dg in DgReqActivos2.Rows)
                {

                    dg.Cells[5].Value = diligencia;
                    tiG.mensaje = string.Format( "procesando...{0}% ", i * 100 / total);
                    backgroundWorker1.ReportProgress(i*100/total, tiG);
                   
                    i++;
                    

                }
            pbCarga.Value = 0;
            lblListo.Text = "Listo.";
            MessageBox.Show("Finalizado");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            TaskInfo tiG = (TaskInfo)e.UserState;
            pbCarga.Value = e.ProgressPercentage;
            lblListo.Text = tiG.mensaje;
            lblListo.Update();
            
            
            
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgReqActivos2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                DataGridViewCell cell = DgReqActivos2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                    cell.Value = cell.Value.ToString().ToUpper() ;
            }
        }
    }
}



