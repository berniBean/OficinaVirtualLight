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
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class PantallaConcentradoOficios : Form
    {
        private obtenerOficiosSQL obtenerOficiosConcentradoSQL;
        private int _emision;
        private string _nombreEmision;
        private int _idSup;
        private ListCOficios oficiosConcentrado;
        obtenerPDFSql listadoPDF;
        ListPdfSql listadoPDFDB;
        private int _tipoSesion;
        List<ChocoPdfs> pdfLocal = new List<ChocoPdfs>();

        obtenerURL obUrl;
        private CListaURL listaUrl;
        public PantallaConcentradoOficios(int idSup,int emision, string nombreEmision,int tipoS)
        {
            InitializeComponent();
            _emision = emision;
            _nombreEmision = nombreEmision;
            _idSup = idSup;
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
                obUrl = factoryURL.maker(factoryURL.PLUS);
            }

            cargarTableroOficiosConcentrado().Wait();
        }

        private async Task cargarTableroOficiosConcentrado()
        {
            oficiosConcentrado = await obtenerOficiosConcentradoSQL.listadoConcentradoOficioSql(_nombreEmision,_emision, _idSup);

            listadoPDFDB = await listadoPDF.listadoOficiosPDF(_emision, CUserLoggin.idUser);

            cOficiosBOBindingSource.DataSource = oficiosConcentrado;

            List<string> elementos = new List<string>
            {
                "--Seleccionar--"
            };

            ZonaCombo.Items.AddRange(elementos.ToArray());
            ZonaCombo.SelectedIndex = 0;

            var source = oficiosConcentrado.Select(x => x.Zona).Distinct().ToList();
            elementos.AddRange(source);

            ZonaCombo.Sorted = true;
            
            ZonaCombo.DataSource = elementos;


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

            if (pdfLocal.Count() > 0)
            {
                pdfLocal.Clear();
            }
        }

        private IEnumerable<consultaPDF> QueryPDF()
        {
            CUserLoggin.tipoDocumentoDescarga = "Firmados";

            var EnumerableBusqueda = pdfLocal.AsEnumerable();

            if (EnumerableBusqueda.Count().Equals(0))
            {
                var consulta = from local in listadoPDFDB
                               select new consultaPDF()
                               {
                                   name = local.numReq,
                                   rutaFtp = local.rutaFTP,
                                   numCtrl = local.numCtrl
                               };

                return consulta;
            }
            else
            {
                var consulta = from local in listadoPDFDB
                               join busqueda in EnumerableBusqueda on local.numReq equals busqueda._numDocto
                               select new consultaPDF()
                               {
                                   name = local.numReq,
                                   rutaFtp = local.rutaFTP,
                                   numCtrl = local.numCtrl
                               };


                return consulta;



            }





        }

        private void ZonaCombo_Leave(object sender, EventArgs e)
        {
            if(ZonaCombo.SelectedIndex == 0)
            {
                cOficiosBOBindingSource.DataSource = oficiosConcentrado;
                ZonaCombo.SelectAll();
            }
            else
            {
                var consulta = (from oficos in oficiosConcentrado
                                where oficos.Zona.Equals(ZonaCombo.Text)
                                select oficos).ToList();

                foreach (var item in consulta)
                {
                    var x = item.NumOficio;
                    pdfLocal.Add(new ChocoPdfs() { _numDocto = x.ToString() + ".pdf" });
                }
                
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
                pdfGestor vistaPDf = new pdfGestor( tipo, uri,  numReq, idSAT, ohe, emision);
                vistaPDf.ShowDialog();
            }
        }
    }
}
