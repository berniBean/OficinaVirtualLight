using Singleton;
using Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class DragDropPDF : Form
    {

        private InfoFiles model = new CarpetasFiles(new Archivo(), new NombreArchivos());        
        List<ChocoPdfs> pdfLocal = new List<ChocoPdfs>();
        private BindingSource bs;        
        obtenerPDFSql listadoPDF;
        ListPdfSql listadoPDFDB;        
        private int _emision;
        private int _ejercicioFiscal;
        private string _nombreEmision;
        private int _tipoSesion;
        private string _documento;
        

        public DragDropPDF(int emision, int tipoS, int año, string nombre, string documento = null)
        {
            _emision = emision;
            _ejercicioFiscal = año;
            _nombreEmision = nombre;
            InitializeComponent();
            lblEmision.Text = _emision.ToString();
            lblAño.Text = _ejercicioFiscal.ToString();
            lblNombre.Text = _nombreEmision;
            _tipoSesion = tipoS;
            _documento = documento;
            bs = new BindingSource();

            if (tipoS == 1)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                readListadoRequerimientosAsync().Wait();
            }

            if (tipoS == 2)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                if (documento.Equals("firmados"))
                {
                    readListadoFirmadosAsync().Wait();
                }

                if (documento.Equals("oficos"))
                {

                }
                    

                else
                {
                    readListadoRequerimientosAsync().Wait();

                }
            }
            if (tipoS == 3)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                readListadoMultasAsync().Wait();
            }

            if (tipoS == 4)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);

                if (documento.Equals("firmados"))
                {
                    ReadListMultasFirmadosAsync().Wait();
                }
                else
                {
                    readListadoMultasAsync().Wait();
                }

                    
            }
        }

        private async Task readListadoFirmadosAsync()
        {
            listadoPDFDB = await listadoPDF.ListadoPdfFirmados(_emision);
        }



        private async Task readListadoRequerimientosAsync()
        {

            listadoPDFDB = await listadoPDF.listadoPDFSql(_emision);
        }

        

        private async Task readListadoMultasAsync() 
        {
            listadoPDFDB = await listadoPDF.listadoPdfMultasSql(_emision);
        }

        private async Task ReadListMultasFirmadosAsync()
        {
            listadoPDFDB = await listadoPDF.listadoPdfMultasFirmadosSql(_emision);
        }

        private void DropFiles_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                model.dir = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                model.performDirection();
                if (model.performTypeFile() == "File")
                    model.DataFileService = new NombreArchivo();
                else
                    model.DataFileService = new NombreArchivos();


                pdfLocal = model.performNameFiles();
            }
            catch (Exception)
            {

                MessageBox.Show("No soporta selección multiple de archivos o carpetas");
            }




            bs.DataSource = QueryPDF().OrderBy(x => NumberOrderHelper.ObtenerNumeroAntesGuionBajo(x.name));

            DropFiles.DataSource = bs;
            DropFiles.DisplayMember = "name";
            bs.CurrencyManager.Refresh();
        }

        private IEnumerable<consultaPDF> QueryPDF()
        {
            IEnumerable<consultaPDF> consulta = default;
            
            if (chRemplazo.Checked || _documento.Equals("firmados")) {
                consulta = from local in pdfLocal
                           join db in listadoPDFDB on local._name equals db.numReq
                           select new consultaPDF() { name = local._name, fullName = local._fullName, rutaFtp = db.rutaFTP, numCtrl = db.numCtrl };

            }
            else
            {
                consulta = from local in pdfLocal
                           join db in listadoPDFDB on local._name equals db.numReq
                           where db.estatusPDF.Equals("pendiente")
                           select new consultaPDF() { name = local._name, fullName = local._fullName, rutaFtp = db.rutaFTP, numCtrl = db.numCtrl };
            }





            if (consulta.Any())
            {
                return consulta.ToList();
            }
            else {
                MessageBox.Show("Los elementos no pertenencen a la emisión seleccionada o ya han sido cargados");
                return default;
            }

            
        }

        private void DropFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bs.DataSource = model.PerformClearList();
            DropFiles.DataSource = bs;
            DropFiles.DisplayMember = "_name";
            bs.CurrencyManager.Refresh();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            try
            {
                if (_documento.Equals("firmados"))
                {
                    await new CargaFirmadosPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                    btnCargar.Enabled = true;
                }
                else
                {
                    await new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                    btnCargar.Enabled = true;
                }
            }
            catch (Exception)
            {
                if (_documento.Equals("firmados"))
                {
                    new CargaFirmadosPdf(tpbProgresBar, listadoPDF, _tipoSesion).crearCarpetaFTP(QueryPDF().ToList());
                    
                }
                else
                    new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).crearCarpetaFTP(QueryPDF().ToList());
            }
            finally
            {
                if (_documento.Equals("firmados"))
                {
                    await new CargaFirmadosPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                    btnCargar.Enabled = true;
                }
                else
                {

                    await new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                    btnCargar.Enabled = true;
                }
            }
                        

        }





    }
} 
