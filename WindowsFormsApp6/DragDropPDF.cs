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
        

        public DragDropPDF(int emision, int tipoS, int año, string nombre)
        {
            _emision = emision;
            _ejercicioFiscal = año;
            _nombreEmision = nombre;
            InitializeComponent();
            lblEmision.Text = _emision.ToString();
            lblAño.Text = _ejercicioFiscal.ToString();
            lblNombre.Text = _nombreEmision;
            _tipoSesion = tipoS;
            bs = new BindingSource();

            if (tipoS == 1)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                readListadoRequerimientosAsync().Wait();
            }

            if (tipoS == 2)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                readListadoRequerimientosAsync().Wait();
            }
            if (tipoS == 3)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.RIF);
                readListadoMultasAsync().Wait();
            }

            if (tipoS == 4)
            {
                listadoPDF = pdfSQLFactory.maker(pdfSQLFactory.PLUS);
                readListadoMultasAsync().Wait();
            }
        }

        private async Task readListadoRequerimientosAsync()
        {
            listadoPDFDB = await listadoPDF.listadoPDFSql(_emision);
        }

        private async Task readListadoMultasAsync() 
        {
            listadoPDFDB = await listadoPDF.listadoPdfMultasSql(_emision);
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




            bs.DataSource = QueryPDF();

            DropFiles.DataSource = bs;
            DropFiles.DisplayMember = "name";
            bs.CurrencyManager.Refresh();
        }

        private IEnumerable<consultaPDF> QueryPDF()
        {
            var consulta = from local in pdfLocal
                           join db in listadoPDFDB on local._name equals db.numReq
                           where db.estatusPDF.Equals("pendiente")
                           select new consultaPDF() { name = local._name, fullName = local._fullName, rutaFtp = db.rutaFTP, numCtrl = db.numCtrl };

            

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
                await new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                btnCargar.Enabled = true;
            }
            catch (Exception)
            {

                new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).crearCarpetaFTP(QueryPDF().ToList());
            }
            finally
            {
                await new CargaPdf(tpbProgresBar, listadoPDF, _tipoSesion).pdfCargar(QueryPDF());
                btnCargar.Enabled = true;
            }
                        

        }





    }
} 
