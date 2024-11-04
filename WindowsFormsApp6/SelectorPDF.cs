using CleanArchitecture.Helpers;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper;

namespace WindowsFormsApp6
{
    public partial class PDFTipo : Form
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
        private string _tipoMulta;

        private string path;
        private string folder;
        private string fullFilePath;

        obtenerRequeridos obReq;


        private int selectorTypo = 0;
        public PDFTipo(int tipoDocumento,string tipoMulta, string URI, string numReq, string idSAT, string ohe, string emision,string RFC)
        {
            selectorTypo = tipoDocumento;
            
            InitializeComponent();
            if (tipoDocumento == Pdf.Requerimiento) 
            {
                cbDocumento.Items.AddRange(new object[] { "Escaneados", "Firmados" });
            }
            if(tipoDocumento == Pdf.Multa)
            {
                cbDocumento.Items.AddRange(new object[] { "Escaneados", "Firmados","Recibo" });
            }

            _RFC = RFC;
            _tipoMulta = tipoMulta;
            _numReq = numReq;
            _idSAT = idSAT;
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


        }

        public PDFTipo(int tipoDocumento,int tipo, string numReq, string RFC, string rs, string idSAT, string diligencia, string citatorio, string notificacion, string URI, string emision, string ohe)
        {
            selectorTypo = tipoDocumento;

            InitializeComponent();

            if (tipoDocumento == Pdf.Requerimiento)
            {
                cbDocumento.Items.AddRange(new object[] { "Escaneados", "Firmados" });
            }
            if (tipoDocumento == Pdf.Multa)
            {
                cbDocumento.Items.AddRange(new object[] { "Escaneados", "Firmados", "Recibo" });
            }

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
            lblNotificacion.Text = DateFormatHelper.ConvertTime(_notificacion);
            lblURI.Text = _uri + "/" + _ohe;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folder = path + "\\temp";
            fullFilePath = folder + "\\" + _idSAT + ".pdf";

            obReq = factoryRequerimientos.maker(factoryRequerimientos.PLUS);
        }

        private void cbDocumento_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string seleccionado = cbDocumento.SelectedItem?.ToString() ?? "Ninguno";

            if (selectorTypo == Pdf.Requerimiento) 
            {
                if (seleccionado == "Escaneados")
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
                    catch (Exception)
                    {
                        MessageBox.Show("Sin archivo de pdf");
                    }
                }

                if (seleccionado == "Firmados")
                {

                    //_nuevoNombreArchivo = _emision + "/" + _ohe + "/" + _numReq + ".pdf";
                    //FileInfo objFile = new FileInfo(_nuevoNombreArchivo);
                    //uri = new Uri(_uri + "/" + _nuevoNombreArchivo);
                    //ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

                    _nuevoNombreArchivo =  _emision+ "/REQFirma/"+_numReq+"_"+ _idSAT + ".pdf";
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
                    catch (Exception)
                    {
                        MessageBox.Show("Sin archivo de pdf");
                    }

                }
            }

            if(selectorTypo == Pdf.Multa)
            {
                if (seleccionado == "Escaneados")
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
                    catch (Exception)
                    {
                        MessageBox.Show("Sin archivo de pdf");

                    }
                }

                if (seleccionado == "Firmados")
                {
                    _nuevoNombreArchivo = _emision + "/MultaFirma/" + _numReq + "-" + _tipoMulta + "-" + _RFC + ".pdf";
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
                    catch (Exception)
                    {
                        MessageBox.Show("Sin archivo de pdf");
                    }


                }
                if(seleccionado == "Recibo")
                {
                    _nuevoNombreArchivo = _emision + "/RecibosMultas/" + _numReq + "-" + _tipoMulta + "-" + _ohe + ".pdf";
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
                    catch (Exception)
                    {
                        MessageBox.Show("Sin archivo de pdf");
                    }
                }
            }
            

        }
    }



}
