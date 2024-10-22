 using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

using System.IO;
using WindowsFormsApp6.CAD.DAL;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using CleanArchitecture.Helpers;

namespace WindowsFormsApp6
{
    public partial class pdfGestor : Form
    {
        private string _numReq;
        private string _RFC;
        private string _rs;
        private string _idSAT;
        private string _diligencia;
        private string _citatorio;
        private string _notificacion;
        private string _uri;
        private string _emision;
        private string _ohe;
        private int _tipo;
        private Uri uri;
        private FtpWebRequest ClienteRequest;
        private NetworkCredential credenciales;
        private Stream ftpStream;
        private string _direccionArchivo;
        private string _NombreArchivo;
        private string _nuevoNombreArchivo;
        private string _nuevaRuta;

        private string path;
        private string folder;
        private string fullFilePath;

        private CatObservacionesDAL catalogo = new CatObservacionesDAL();
        private CatObservacionesBO ObCatalogo = new CatObservacionesBO();
        private CListaCatObservaciones ListaObservaciones;

        obtenerRequeridos obReq;
        public pdfGestor(int tipo, string URI, string numReq, string idSAT, string ohe,string emision)
        {
            InitializeComponent();
            btnAbrir.Visible = false;
            btnGuardar.Visible = false;
            groupBox1.Visible = false;
            SplitControlesObservaciones.SplitterDistance = 85;
            _numReq = numReq;
            _idSAT = idSAT;
            _tipo = tipo;
            _uri = URI;
            _emision = emision;
            _ohe = ohe;
            lblNumREQ.Text = _numReq;
            lblSAT.Text = _idSAT;
            lblRFC.Text = _RFC;
            lblRs.Text = _rs;
            lblDiligencia.Text = _diligencia;
            lblCitatorio.Text = DateFormatHelper.ConvertTime(_citatorio);
            lblNotificacion.Text = DateFormatHelper.ConvertTime(_notificacion);
            lblURI.Text = _uri + "/" + _ohe;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folder = path + "\\temp";
            fullFilePath = folder + "\\" + _idSAT + ".pdf";

            obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
            abrirArchivo();
            CargarCatalogo();
        }
        public pdfGestor(int tipo,string numReq,string RFC,string rs,string idSAT,string diligencia,string citatorio,string notificacion, string URI,string emision,string ohe)
        {
            InitializeComponent();
            btnAbrir.Enabled = false;
            btnGuardar.Enabled = false;
            _numReq = numReq;
            _RFC = RFC;
            _rs = rs;
            _idSAT = idSAT;
            _diligencia = diligencia;
            _citatorio = citatorio;
            _notificacion = notificacion;
            _tipo = tipo;
            _uri = URI;
            _emision = emision;
            _ohe = ohe;
            lblNumREQ.Text = _numReq;
            lblSAT.Text = _idSAT;
            lblRFC.Text = _RFC;
            lblRs.Text = _rs;
            lblDiligencia.Text = _diligencia;
            lblCitatorio.Text = DateFormatHelper.ConvertTime(_citatorio);
            lblNotificacion.Text =  DateFormatHelper.ConvertTime( _notificacion);
            lblURI.Text = _uri + "/" + _ohe;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folder = path + "\\temp";
            fullFilePath = folder + "\\" + _idSAT + ".pdf";

            obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
            abrirArchivo();
            CargarCatalogo();


        }

        struct FtpSetting
        {
            public string Server { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }
            public string Domain { get; set; }
            public string direccionArchivo { get; set; }
        }
        FtpSetting _inputParameter;
        private void btnAbrir_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames=true, Filter = "Archivos PDF(*.pdf)|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    credenciales.Domain = "efloresp";
                    credenciales.UserName = "PinkyNet";
                    credenciales.Password = "berni3235";
                    _inputParameter.Server = _uri;
                    _inputParameter.FileName = fi.Name;
                    _inputParameter.FullName = fi.FullName;

                    LayObservaciones.src = fi.FullName;
                }
            }

            //try
            //{
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //Código para abrir y leer archivo
            //        _direccionArchivo = openFileDialog1.FileName;
            //        _NombreArchivo = openFileDialog1.SafeFileName;
            //        vistaPDF.src = openFileDialog1.FileName;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Ocurrió un error: " + ex.ToString());
            //}



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CListaRequeridosBO observacion = new CListaRequeridosBO();

            if (chkActaNotificacion.Checked)            
                observacion.ActaNotificacion = true;            
            else            
                observacion.ActaNotificacion = false;


            if (ChkChitatorio.Checked)
                observacion.ActaCitatorio = true;
            else
                observacion.ActaCitatorio = false;

            if (chkActaNotificacion.Checked && ChkChitatorio.Checked)
                observacion.NotificacionCitatorio = true;
            else
                observacion.NotificacionCitatorio = false;

            observacion.NumCtrl = _idSAT;
            observacion.Observaciones = cmbObservacion.Text;
            observacion.NotasObservaciones = textNotas.Text;

            //obReq.ObservacionesRequerimientos(observacion);
            //if(backgroundWorker.IsBusy != true)
            //{
            //    backgroundWorker.RunWorkerAsync();
            //}
        }

        private void CargarCatalogo()
        {
            ListaObservaciones = catalogo.GetCatObservacion();

            cmbObservacion.DataSource = ListaObservaciones;
            
            
        }

        private void cmbObservacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbObservacion.SelectedIndex;
            var descripcion = ListaObservaciones[index].Descripcion.ToString();
            txtDescripcionCorta.Text = descripcion;
        }
        private void abrirArchivo()
        {
           
            _nuevoNombreArchivo = _emision + "/" + _ohe + "/" + _numReq + ".pdf";
            FileInfo objFile = new FileInfo(_nuevoNombreArchivo);
            uri = new Uri(_uri + "/" + _nuevoNombreArchivo);
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();

            credenciales.Domain = "efloresp";
            credenciales.UserName = "PinkyNet";
            credenciales.Password = "berni3235";

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;
            try
            {
                FtpWebResponse response = (FtpWebResponse)ClienteRequest.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                byte[] bytes = null;
                using (var memstream = new MemoryStream())
                {
                    reader.BaseStream.CopyTo(memstream);
                    bytes = memstream.ToArray();
                }

                var oDocument = bytes;

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                if (File.Exists(fullFilePath))
                    File.Delete(fullFilePath);

                File.WriteAllBytes(fullFilePath, oDocument);
                LayObservaciones.src = fullFilePath;

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
                MessageBox.Show("Sin archivo de pdf");
                btnAbrir.Enabled = true;
                btnGuardar.Enabled = true;
            }



        }

        private void Cargar()
        {


            _nuevoNombreArchivo = _emision + "/" + _ohe + "/" + _numReq + ".pdf";
            uri = new Uri(_uri + "/" + _nuevoNombreArchivo);
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();


            credenciales.Domain = "eflorespp";
            credenciales.UserName = "PinkyNet";
            credenciales.Password = "berni3235";

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;

            ClienteRequest.Method = WebRequestMethods.Ftp.UploadFile;
            //FtpWebResponse respuesta = (FtpWebResponse)ClienteRequest.GetResponse();
            //rutina de subida
            Stream destino = ClienteRequest.GetRequestStream();
            _direccionArchivo = _inputParameter.FullName;
            FileStream origen = new FileStream(_direccionArchivo, FileMode.Open, FileAccess.Read);
            crearArchivo(origen, destino);

            //MessageBox.Show("Archivo: " + _idSAT + ".pdf" + " Guardado");
        }

        private void crearCarpetaEmision(string nuevaRuta)
        {
            ClienteRequest = (FtpWebRequest)WebRequest.Create(nuevaRuta);
            
            credenciales = new NetworkCredential();

            credenciales.Domain = "eflorespp";
            credenciales.UserName = "PinkyNet";
            credenciales.Password = "berni3235";

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;

            
            credenciales = new NetworkCredential();
            FtpWebResponse response = (FtpWebResponse)ClienteRequest.GetResponse();
        }

        private void crearArchivo(Stream origen, Stream destino)
        {

            byte[] buffer = new byte[1024];
            int bytesLeidos = origen.Read(buffer, 0, 1024);
            double total = (double)origen.Length;
            int byteRead = 0;
            double read = 0;
            while (bytesLeidos != 0)
            {
                if (!backgroundWorker.CancellationPending)
                {

                    destino.Write(buffer, 0, bytesLeidos);
                    bytesLeidos = origen.Read(buffer, 0, 1024);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker.ReportProgress((int)percentage);
                }
            }

            origen.Close();
            destino.Close();
        }



        private void pdfGestor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(folder))
                Directory.Delete(folder, true);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Cargar();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = $"Cargando {e.ProgressPercentage} %";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Carga completada";
            MessageBox.Show("Archivo: " + _idSAT + ".pdf" + " Guardado");
        }

 


    }
}
