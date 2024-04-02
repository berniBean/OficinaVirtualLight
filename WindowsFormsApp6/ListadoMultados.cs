using DataGridViewAutoFilter;
using MoreLinq;
using Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper.DataGridHelper;
using WindowsFormsApp6.structs;
using static WindowsFormsApp6.Form4;

namespace WindowsFormsApp6
{
    public partial class ListadoMultados : Form
    {
        private CargarFechasOficios cargarFechasOficios;

        BusquedaDelegado BusquedaMasivaDelegada;
        SetRequerimiento setRequerimientoDelegado;
        DescargarDelegado DescargarDelegado;
        SetTipoMulta setTipoMultaDelegada;

        obtenerTableroSup tableroSuper;
        obtenerRequeridos obReq;
        obtenerBusqueda obBusqueda;
        obtenerBusquedaMultas obBuscarMultas;
        CListaTableroAdmin listadoReq;
        ListaClistaRequeridos listadoMultas;
        private int _emision;

        private CListaURL listaUrl;
        obtenerURL obUrl;
        obtenerURL obURLR;

        obtenerPDFSql listadoPDF;
        ListPdfSql listadoPDFDB;
        List<ChocoPdfs> pdfLocal = new List<ChocoPdfs>();

        private string tipoMulta;
        private int _tipoSesion;

        public ListadoMultados(int emision, int tipoS)
        {
            _tipoSesion = tipoS;
            _emision = emision;
            InitializeComponent();
            tsBusqueda.CharacterCasing = CharacterCasing.Upper;

            if (tipoS == 1)
            {
                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                obURLR = factoryURL.maker(factoryURL.MRIF);
                obUrl = factoryURL.maker(factoryURL.MRIF);
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                readListadoAsync().Wait();
            }

            if (tipoS == 2)
            {
                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                obURLR = factoryURL.maker(factoryURL.MPLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                readListadoAsync().Wait();


            }

            BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            setRequerimientoDelegado = new SetRequerimiento(SetRequeimientoComo);
            setTipoMultaDelegada = new SetTipoMulta(setTipoMulta);
            DescargarDelegado = new DescargarDelegado(DescargaPDF);

            cargarTableroListadoMultados();
            CargarDiasCalendario();

            this.dgMultados.Columns[15].DefaultCellStyle.Format = "C";
            this.dgMultados.Columns[16].DefaultCellStyle.Format = "C";

        }

        private void CargarDiasCalendario()
        {
            var listado = CUserLoggin.DiasFestivos;
            foreach(var dia in listado)
            {
                ListCalendar.AddBoldedDate(dia.DiaFeriado);
            }
        }

        private async Task  readListadoAsync() 
        {
            listadoPDFDB =await listadoPDF.listadoPdfMultasSql(_emision);
        }
        private async Task DescargaPDF()
        {
            await new CargaPdf(tsProgress, listadoPDF,_tipoSesion).pdfDescarga(QueryPDF().ToList());
            tsProgress.Value = 0;
        }

        private Task  SetRequeimientoComo(string diligencia)
        {
            return default;
        }
        private async Task setTipoMulta(string tipoM)
        {
            await Task.Run(() =>
            {
                if (tipoM != "")
                    tipoMulta = tipoM;
            });


        }

        private void OheSelect_Leave(object sender, EventArgs e)
        {
            if (OheSelect.SelectedIndex == 0)
            {
                cListaRequeridosBOBindingSource.DataSource = listadoMultas.ToDataTable();

            }
            else
            {
                var consulta = (from multas in listadoMultas
                                where multas._OHE.Contains(OheSelect.Text)
                                select multas).ToList();

                cListaRequeridosBOBindingSource.DataSource = consulta;
            }
        }

        private void  setDTable(ListaClistaRequeridos listadoMultas) 
        {
            cListaRequeridosBOBindingSource.DataSource = listadoMultas.ToDataTable();

            dgMultados.AutoResizeColumns();
            dgMultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            

            List<string> elementos = new List<string>
            {
                "--Seleccionar--"
            };
            OheSelect.Items.AddRange(elementos.ToArray());
            OheSelect.SelectedIndex = 0;

            var source = listadoMultas.Select(x => x._OHE).Distinct().ToList();
            elementos.AddRange(source);

            OheSelect.Sorted = true;
            OheSelect.ComboBox.DataSource = elementos;
        }

        private void busquedaMasiva(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda)
        {
            ListaClistaRequeridos listMultaDescarga = new ListaClistaRequeridos();
            var consulta = (from local in listadoMultas
                            join busqueda in ReturnLstBusqueda on local.NumCtrl equals busqueda.numCtrl
                            where local._tipoMulta.Equals(tipoMulta)
                            select new CListaRequeridosBO()
                            {
                                    _zona = local._zona,
                                    _OHE = local._OHE,
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
                                     Estatus = local.Estatus,
                                    _estatusPDF = local._estatusPDF
                            }).ToList();
                foreach (var item in consulta)
                {
                    var x = item._numMulta.ToString() + ".pdf";
                    listMultaDescarga.Add(item);
                    pdfLocal.Add(new ChocoPdfs() { _name = x });
                }
            setDTable(listMultaDescarga);
        }

        private async void cargarTableroListadoMultados()
        {
            listadoMultas = await tableroSuper.GetTableroMultasGENAdmin(_emision, CUserLoggin.idUser);
            setDTable(listadoMultas);
        }

        private void tsBusquedaMasiva_Click(object sender, EventArgs e)
        {
            Form4 Ibusqueda = new Form4();
            Ibusqueda.tipoVentana = "Super";
            Ibusqueda.tipoMulta = "MPLUS_";
            Ibusqueda.setTipoM += new Form4.SetTipoMulta(setTipoMulta);
            Ibusqueda.ejecutar += new Form4.BusquedaDelegado(busquedaMasiva);
            Ibusqueda.setDiligencia += new Form4.SetRequerimiento(SetRequeimientoComo);
            Ibusqueda.ejecutarDescarga += new Form4.DescargarDelegado(DescargaPDF);

            Ibusqueda.ShowDialog();
        }

        private void tsBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
                && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                && dgMultados.CurrentCell != null
                && dgMultados.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }


            if (e.KeyValue == 13)//enter
            {
                if (!string.IsNullOrEmpty(tsBusqueda.Text))
                {
                    BusquedaRIF(tsBusqueda.Text);
                }
                else
                {
                    BusquedaRIF(tsBusqueda.Text);
                }

                dgMultados.AutoResizeColumns();
                dgMultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }





        private void BusquedaRIF(string datoBusqueda)
        {
            int totalBusqueda;
            ListaClistaRequeridos listMultaBusqueda = new ListaClistaRequeridos();
            if (string.IsNullOrEmpty(datoBusqueda))
            {

                setDTable(listadoMultas);
            }
            

                var consulta = (from local in listadoMultas
                                where local.Rfc.Contains(datoBusqueda) ||
                                local.RazonSocial.Contains(datoBusqueda)
                                select new CListaRequeridosBO()
                                {
                                    _zona = local._zona,
                                    _OHE = local._OHE,
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
                                    Estatus = local.Estatus,
                                    _estatusPDF = local._estatusPDF
                                }).ToList();

                totalBusqueda = consulta.Count();
                if (totalBusqueda.Equals(0))
                {
                    MessageBox.Show("No se encontraron datos");
                    return;
                }
                else
                {
                    foreach (var item in consulta)
                    {

                        listMultaBusqueda.Add(item);                        
                    }
                    setDTable(listMultaBusqueda);
                }



            

            tsBusqueda.SelectAll();
        }

        private void showAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dgMultados);
        }
        private IEnumerable<consultaPDF> QueryPDF()
        {
            var pd = pdfLocal.Count();
            var consulta = from local in pdfLocal
                           join db in listadoPDFDB on local._name equals db.numReq
                           select new consultaPDF() { name = local._name, rutaFtp = db.rutaFTP, numCtrl = db.numCtrl };

            return consulta;
        }

        private void tsFiltrar_Click(object sender, EventArgs e)
        {
            EnableGridFilter(true);
        }

        private void EnableGridFilter(bool v)
        {

            DataGridzona.FilteringEnabled = v;
            DataGridOHE.FilteringEnabled = v;
            DataGridTMulta.FilteringEnabled = v;
            DataGridnumMulta.FilteringEnabled = v;
            DataGridRFC.FilteringEnabled = v;
            DataGridTipoC.FilteringEnabled = v;
            DataGridnumCtrlReq.FilteringEnabled = v;
            DataGridDetalleEmi.FilteringEnabled = v;
            DataGridNumReq.FilteringEnabled = v;
            DataGridDiligenicia.FilteringEnabled = v;
            DataGridFC.FilteringEnabled = v;
            DataGridFN.FilteringEnabled = v;
            DataGridFP.FilteringEnabled = v;
            DataGridimporte.FilteringEnabled = v;
            DataGridhonorarios.FilteringEnabled = v;
            DataGridfechaVencimiento.FilteringEnabled = v;
            DataGridobservaciones.FilteringEnabled = v;
            DataGridejecucion.FilteringEnabled = v;
            DataGridestatus.FilteringEnabled = v;
            DataGridestatusPDF.FilteringEnabled = v;
        }


        private void dgMultados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgMultados);
            if (string.IsNullOrEmpty(filterStatus))
            {
                ShowAllLabel.Visible = false;
                FilterStatusLabel.Visible = false;
            }
            else
            {
                ShowAllLabel.Visible = true;
                FilterStatusLabel.Visible = true;
                FilterStatusLabel.Text = filterStatus;
            }
        }

        private void dgMultados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                listaUrl = obURLR.listaURI();
                string uri = listaUrl[0]._URL.ToString();
                string numReq = dgMultados.CurrentRow.Cells[4].Value.ToString();
                string RFC = dgMultados.CurrentRow.Cells[5].Value.ToString();
                string idSAT = dgMultados.CurrentRow.Cells[7].Value.ToString();
                string rs = dgMultados.CurrentRow.Cells[8].Value.ToString();
                string diligencia = dgMultados.CurrentRow.Cells[11].Value.ToString();
                string Citatorio = dgMultados.CurrentRow.Cells[12].Value.ToString();
                string Notificacion = dgMultados.CurrentRow.Cells[13].Value.ToString();
                string ohe = dgMultados.CurrentRow.Cells[2].Value.ToString();
                string emision = _emision.ToString();
                int tipo = 1;

                pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, rs, idSAT, diligencia, Citatorio, Notificacion, uri, emision, ohe);
                vistaPDf.ShowDialog();
            }
        }





        private void dgMultados_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex != -1)
            {
                dgMultados.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void ListadoMultados_Load(object sender, EventArgs e)
        {
            dgMultados.ReadOnly = false;
            foreach(DataGridViewColumn column in dgMultados.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }

        private void dgMultados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Formatting)
            {
                MessageBox.Show("la fecha debe ser del tipo [dd/mm/aaaa]");
            }
        }

        private void dgMultados_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgMultados.CurrentCell.ColumnIndex !=11 || dgMultados.CurrentCell.ColumnIndex != 15 || dgMultados.CurrentCell.ColumnIndex != 16)
            {
                try
                {
                    DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

                    dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
                    dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
                }
                catch (InvalidCastException ex)
                {

                    throw;
                }
            }
        }

        private void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgMultados.CurrentCell.ColumnIndex == 11 || dgMultados.CurrentCell.ColumnIndex == 18 )
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

        private void dgMultados_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.V)
            {
                GridHelper<ListaClistaRequeridos>.pegar_portapapeles(dgMultados,ListCalendar,listadoMultas)
            }
        }
    }
}
