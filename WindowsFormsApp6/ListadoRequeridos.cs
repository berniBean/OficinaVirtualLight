using DataGridViewAutoFilter;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using static WindowsFormsApp6.Form4;
using WindowsFormsApp6.structs;
using Singleton;
using WindowsFormsApp6.Cache;
using CleanArchitecture.ClasesDB;
using CleanArchitecture.Helpers;
using System.Threading.Tasks;
using WindowsFormsApp6.Helper.DataGridHelper;

namespace WindowsFormsApp6
{
    public partial class ListadoRequeridos : Form
    {
        BusquedaDelegado BusquedaMasivaDelegada;
        SetRequerimiento setRequerimientoDelegado;
        DescargarDelegado DescargarDelegado;

        obtenerTableroSup tableroListado;
        obtenerRequeridos obReq;
        obtenerBusqueda obBusqueda;
        obtenerBusquedaMultas obBuscarMultas;
        CListaTableroAdmin listadoReq;
        private int _emision;
        private int _tipoSesion;
        private string _NombreEmision;
        private CListaURL listaUrl;
        obtenerURL obUrl;
        obtenerURL obURLR;

        obtenerPDFSql listadoPDF;
        ListPdfSql listadoPDFDB;
        List<ChocoPdfs> pdfLocal = new List<ChocoPdfs>();


        public ListadoRequeridos(int emision,string nombreEmision,  int tipoS)
        {
            _emision = emision;
            _tipoSesion = tipoS;
            _NombreEmision = nombreEmision;
            InitializeComponent();
            tbBusqueda.CharacterCasing = CharacterCasing.Upper;

            if (tipoS == 1)
            {
                tableroListado = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                obReq = factoryRequerimientos.maker(factoryRequerimientos.RIF);
                obBusqueda = factoryBusqueda.maker(factoryBusqueda.RIF);
                obURLR = factoryURL.maker(factoryURL.RIF);
                obUrl = factoryURL.maker(factoryURL.MRIF);
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                
            }

            if (tipoS == 2)
            {
                tableroListado = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
                obBusqueda = factoryBusqueda.maker(factoryBusqueda.PLUS);
                obURLR = factoryURL.maker(factoryURL.PLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                
            }

            BusquedaMasivaDelegada = new BusquedaDelegado(busquedaMasiva);
            setRequerimientoDelegado = new SetRequerimiento(SetRequeimientoComo);
            DescargarDelegado = new DescargarDelegado(DescargaPDF);


            cargarTableroListadoRequeridos();
           
        }

        private void CargarDiasCalendarioAsync()
        {
            var listado = CUserLoggin.DiasFestivos;

            foreach (var item in listado)
            {
                CalendarioFechas.AddBoldedDate(item.DiaFeriado);
            }

            CalendarioFechas.UpdateBoldedDates();
        }

        private Task SetRequeimientoComo(string diligencia)
        {
            return default;
        }
        private async void tsExcel_Click(object sender, EventArgs e)
        {
            var consulta = (from local in listadoReq
                            select new ReporteGeneralRequerimientos()
                            {
                                Zona = local._zona,
                                Ohe = local._ohe,
                                NumReq = local._numReq,
                                RFC = local._rfc,
                                NumCtrl = local._numCtrl,
                                RazonSocial = local._rs,
                                Diligencia = local._diligencia,
                                Notificacion =  local._fechaNotificacion,
                                Citatorio = local._fechaCitatorio,
                                Observaciones = local._observaciones,
                                MalCaputurado = local._malCapturado
                                

                            }).ToList();

            await new ConvertExcel(tsProgreso,_NombreEmision).Writer(consulta);
            tsProgreso.Value = 0;
        }

        private void busquedaMasiva(IEnumerable<busquedaMasivaDO> ReturnLstBusqueda)
        {
            CListaTableroAdmin listDescarga = new CListaTableroAdmin();
            //listadoReq =  tableroListado.GetListadoCompleto(_emision);
            var consulta = (from local in listadoReq
                            join busqueda in ReturnLstBusqueda on local._numCtrl equals busqueda.numCtrl


                            
                        select new CTableroAdminBO()
                        {
                            _zona = local._zona,
                            _ohe = local._ohe,
                            _municipio = local._municipio,
                            _numReq = local._numReq,
                            _rfc = local._rfc,
                            _numCtrl = local._numCtrl,
                            _rs = local._rs,
                            _diligencia = local._diligencia,
                            _fechaNotificacion = local._fechaNotificacion,
                            _fechaCitatorio = local._fechaCitatorio,
                            _estatus = local._estatus,
                            _pdf = local._pdf
                        }).ToList();
            foreach (var item in consulta)
            {
               var x = item._numReq.ToString() + ".pdf";                
                listDescarga.Add(item);
                pdfLocal.Add(new ChocoPdfs() { _name = x});
            }
            cListaTableroAdminBindingSource.DataSource = listDescarga.ToDataTable();//moreLinq            
            requeridos.AutoResizeColumns();
            requeridos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        private async void cargarTableroListadoRequeridos()
        {

            listadoReq = await tableroListado.GetListadoCompleto(_emision,CUserLoggin.idUser);
            cListaTableroAdminBindingSource.DataSource = listadoReq.ToDataTable();//moreLinq
            //requeridos.DataSource = listadoReq.ToDataTable();//moreLinq
            requeridos.AutoResizeColumns();
            requeridos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listadoPDFDB= await listadoPDF.listadoPDFSql(_emision);

            List<string> elementos = new List<string>
            {
                "--Seleccionar--"
            };
            OheSelect.Items.AddRange(elementos.ToArray());
            OheSelect.SelectedIndex = 0;

            var source = listadoReq.Select(x => x._ohe).Distinct().ToList();
            elementos.AddRange(source);

            OheSelect.Sorted = true;

            OheSelect.ComboBox.DataSource = elementos;


        }

        private void EnableGridFilter(bool v)
        {

            dataGridZona.FilteringEnabled = v;
            dataGridOHE.FilteringEnabled = v;
            dataGridNumReq.FilteringEnabled = v;
            dataGridNumCtrl.FilteringEnabled = v;
            dataGridRFC.FilteringEnabled = v;
            dataGridTipoC.FilteringEnabled = v;
            dataGridDiligencia.FilteringEnabled = v;
            dataGridFC.FilteringEnabled = v;
            dataGridFN.FilteringEnabled = v;
            dataGridEstatus.FilteringEnabled = v;
            dataGridPDF.FilteringEnabled = v;
            dataGridMalCapturado.FilteringEnabled = v;
            dataGridObvservaciones.FilteringEnabled = v;
            
        }

        private void tbBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
                && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                && requeridos.CurrentCell != null
                && requeridos.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }


            if (e.KeyValue == 13)//enter
            {
                if (!string.IsNullOrEmpty(tbBusqueda.Text))
                {
                    BusquedaRIF(tbBusqueda.Text);
                }
                else
                {
                    BusquedaRIF(tbBusqueda.Text);
                }

                requeridos.AutoResizeColumns();
                requeridos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }



        private void OheSelect_Leave(object sender, EventArgs e)
        {

            if(OheSelect.SelectedIndex == 0)
            {
                cListaTableroAdminBindingSource.DataSource = listadoReq;
                tbBusqueda.SelectAll();
            }
            else
            {
                var consulta = (from requerimiento in listadoReq
                                where requerimiento._ohe.Contains(OheSelect.Text)
                                select requerimiento).ToList();
                cListaTableroAdminBindingSource.DataSource = consulta;
            }




        }

        private void BusquedaRIF(string datoBusqueda)
        {
            int totalBusqueda;
            if (string.IsNullOrEmpty(datoBusqueda))
            {

                cListaTableroAdminBindingSource.DataSource = listadoReq;
                tbBusqueda.SelectAll();
            }
            if (datoBusqueda.Equals("PENDIENTE"))
            {
                var consulta = (from requerimiento in listadoReq
                                where requerimiento._estatus.Contains("pendiente") ||
                                requerimiento._pdf.Contains("pendiente")
                                select requerimiento).ToList();
                totalBusqueda = consulta.Count();
                if (totalBusqueda.Equals(0))
                {
                    MessageBox.Show("No se encontraron datos");
                    return;
                }
                else
                {
                    cListaTableroAdminBindingSource.DataSource = consulta;
                }
            }
            else
            {

                var consulta = (from requerimiento in listadoReq
                               where requerimiento._rfc.Contains(datoBusqueda) || 
                               requerimiento._rs.Contains(datoBusqueda)|| 
                               requerimiento._numCtrl.Contains(datoBusqueda)                                    
                               select requerimiento).ToList();

                totalBusqueda = consulta.Count();
                if (totalBusqueda.Equals(0))
                {
                    MessageBox.Show("No se encontraron datos");
                    return;
                }
                else
                {
                    cListaTableroAdminBindingSource.DataSource = consulta;
                }

                
                
            }

            tbBusqueda.SelectAll();


        }

        private void requeridos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(requeridos);
        }

        private void requeridos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(requeridos);
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

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            EnableGridFilter(true);
        }

        private void tsProgreso_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 Ibusqueda = new Form4();
            Ibusqueda.tipoVentana = "Super";            
            Ibusqueda.ejecutar += new Form4.BusquedaDelegado(busquedaMasiva);
            Ibusqueda.setDiligencia += new Form4.SetRequerimiento(SetRequeimientoComo);
            Ibusqueda.ejecutarDescarga += new Form4.DescargarDelegado(DescargaPDF);
            
            Ibusqueda.ShowDialog();
        }

        private async Task DescargaPDF()
        {
            await new CargaPdf(tsProgreso, listadoPDF, _tipoSesion).pdfDescarga(QueryPDF().ToList());
            tsProgreso.Value = 0;
        }

        private IEnumerable<consultaPDF> QueryPDF()
        {
            var pd = pdfLocal.Count();
            //Task<ListPdfSql> listadoPDFDB =  listadoPDF.listadoPDFSql(_emision);
            var consulta = from local in pdfLocal
                           join db in listadoPDFDB on local._name equals db.numReq                           
                           select new consultaPDF() { name = local._name, rutaFtp = db.rutaFTP, numCtrl = db.numCtrl };

            return consulta;
        }

        private void requeridos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void requeridos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                listaUrl = obURLR.listaURI();
                string uri = listaUrl[0]._URL.ToString();
                string numReq = requeridos.CurrentRow.Cells[2].Value.ToString();
                string RFC = requeridos.CurrentRow.Cells[4].Value.ToString();
                string idSAT = requeridos.CurrentRow.Cells[3].Value.ToString();
                string rs = requeridos.CurrentRow.Cells[6].Value.ToString();
                string diligencia = requeridos.CurrentRow.Cells[7].Value.ToString();
                string Citatirio = DateFormatHelper.FechaCorta(Convert.ToDateTime(requeridos.CurrentRow.Cells[8].Value.ToString()));
                string Notificacion = DateFormatHelper.FechaCorta(Convert.ToDateTime(requeridos.CurrentRow.Cells[9].Value.ToString()));
                string ohe = requeridos.CurrentRow.Cells[1].Value.ToString();
                string emision = _emision.ToString();
                int tipo = 1;

                pdfGestor vistaPDf = new pdfGestor(tipo, numReq, RFC, rs, idSAT, diligencia,Citatirio,Notificacion, uri, emision, ohe);
                vistaPDf.ShowDialog();
            }
        }

        private void requeridos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.V)
            {

                GridHelper<ListadoRequeridos>.pegar_portapapeles(requeridos,CalendarioFechas);

                e.Handled = true;
            }
        }


    }
}
