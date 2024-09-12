using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class PantallaConcentradoOficosMULTAS : Form
    {
        private obtenerOficiosSQL obtenerOficiosConcentradoSQL;
        private int _emision;
        private string _nombreEmision;
        private ListCOficios oficiosConcentrado;
        obtenerPDFSql listadoPDF;
        ListPdfSql listadoPDFDB;
        private int _tipoSesion;

        obtenerURL obUrl;
        private CListaURL listaUrl;

        public PantallaConcentradoOficosMULTAS()
        {
            InitializeComponent();
        }
        public PantallaConcentradoOficosMULTAS(int emision, string nombreEmision, int tipoS)
        {
            InitializeComponent();
            _emision = emision;
            _nombreEmision = nombreEmision;
            _tipoSesion = tipoS;
            listadoPDF = default;
            if (tipoS == 1)
            {
                obtenerOficiosConcentradoSQL = OficiosFactory.maker(OficiosFactory.RIF);
            }

            if (tipoS == 2)
            {
                obtenerOficiosConcentradoSQL = OficiosFactory.maker(OficiosFactory.PLUS);
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                obUrl = factoryURL.maker(factoryURL.MPLUS);
            }

            cargarTableroOficiosConcentrado().Wait();
        }

        private async Task cargarTableroOficiosConcentrado()
        {
            oficiosConcentrado = await obtenerOficiosConcentradoSQL.listadoConcentradoOficioMultasSql(_nombreEmision, _emision, CUserLoggin.idUser);
            listadoPDFDB = await listadoPDF.listadoOficiosMultasPDF(_emision, CUserLoggin.idUser);
            cOficiosBOBindingSource.DataSource = oficiosConcentrado;

            setDTable(oficiosConcentrado);

            dgOficiosConcentrado.AutoResizeColumns();
            dgOficiosConcentrado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnOficios_Click(object sender, EventArgs e)
        {
            DescargaPDF().Wait();
        }

        private async Task DescargaPDF()
        {
            await new CargaPdf(tsProgress, listadoPDF, _tipoSesion).pdfDescarga(QueryPDF().ToList());
            tsProgress.Value = 0;
            
        }

        private IEnumerable<consultaPDF> QueryPDF()
         {
            CUserLoggin.tipoDocumentoDescarga = "Firmados";

            var consulta = from local in listadoPDFDB
                           select new consultaPDF()
                           {
                               name = local.numReq,rutaFtp=local.rutaFTP,numCtrl=local.numCtrl
                           };

                return consulta;
            

        }

        private void setDTable(ListCOficios listadoMultas)
        {
            List<string> elementos = new List<string>
            {
                "--Seleccionar--"
            };

            try
            {
                var source = listadoMultas.Select(x => x.Zona).Distinct().ToList();
                elementos.AddRange(source);
            }
            catch (Exception)
            {

                throw;
            }

            ZonaCmb.Sorted = true;
            ZonaCmb.DataSource = elementos;
            
        }

        private void ZonaCmb_Leave(object sender, EventArgs e)
        {
            if(ZonaCmb.SelectedIndex == 0)
            {
                cOficiosBOBindingSource.DataSource = oficiosConcentrado.ToDataTable();
            }
            else
            {
                var consulta = (from oficios in oficiosConcentrado
                                where oficios.Zona.Contains(ZonaCmb.Text)
                                select oficios).ToList();

                cOficiosBOBindingSource.DataSource = consulta;
            }
        }

        private void dgOficiosConcentrado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                listaUrl = obUrl.listaURI();
                string uri = listaUrl[0]._URL.ToString();
                string numReq = dgOficiosConcentrado.CurrentRow.Cells[3].Value.ToString();
                string idSAT = dgOficiosConcentrado.CurrentRow.Cells[3].Value.ToString();
                string ohe = "Oficios";
                string emision = _emision.ToString();
                int tipo = 1;
                pdfGestor vistaPDf = new pdfGestor(tipo, uri, numReq, idSAT, ohe, emision);
                vistaPDf.ShowDialog();
            }
        }
    }
}
