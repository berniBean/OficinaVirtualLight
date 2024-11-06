using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using WindowsFormsApp6.Cache;

namespace WindowsFormsApp6.structs
{
    public class pdfAbstract
    {
        public Uri uri;
        public FtpWebRequest ClienteRequest;
        public NetworkCredential credenciales;
        private string _direccionArchivo;
        private string _nuevoNombreArchivo;

        private string nasCredentials = ConfigurationManager.AppSettings["NAS"];
        private string _userNAS;
        private string _passwordNAS;

        FtpSettings _inputParameter;

        private void setNasConnection()
        {
            var credentials = nasCredentials.Split(';');
            _userNAS = credentials[0].Split('=')[1];
            _passwordNAS = credentials[1].Split('=')[1];

        }



        public async Task cargar(string nameUri, string pdfName, string fullName)
        {
            setNasConnection();

            _nuevoNombreArchivo = nameUri + pdfName;

            uri = new Uri(_nuevoNombreArchivo);
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();
            
            credenciales.UserName = _userNAS;
            credenciales.Password = _passwordNAS;

            ClienteRequest.Credentials = credenciales;
            ClienteRequest.EnableSsl = false;
            ClienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ClienteRequest.KeepAlive = true;
            ClienteRequest.UsePassive = true;
            ClienteRequest.Method = WebRequestMethods.Ftp.UploadFile;

            try
            {
                Stream destino = ClienteRequest.GetRequestStream();
                _direccionArchivo = fullName;
                FileStream origen = new FileStream(_direccionArchivo, FileMode.Open, FileAccess.Read);
                await crearArchivo(origen, destino);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task Descarga(string rutaFtp,string name,string numCtrl, string destino)
        {
            setNasConnection();
            string finalDestino;
            var fullName = rutaFtp + name;

            if (CUserLoggin.tipoDocumentoDescarga.Equals("Firmados") || CUserLoggin.tipoDocumentoDescarga.Equals("Recibos") && CUserLoggin.tipoVentana.Equals("Multas"))
            {
                finalDestino = destino + '\\' + numCtrl;
            }
            
            else if (CUserLoggin.tipoDocumentoDescarga.Equals("Firmados") && CUserLoggin.tipoVentana.Equals("Requerimientos"))
            {
                finalDestino = destino + '\\' + numCtrl;
            }
            else
            {
                finalDestino = destino + '\\' + numCtrl + ".pdf";
            }

            
             
            _nuevoNombreArchivo = fullName;           
            uri = new Uri(fullName);
            ClienteRequest = (FtpWebRequest)WebRequest.Create(uri);

            credenciales = new NetworkCredential();

            
            credenciales.UserName = _userNAS;
            credenciales.Password = _passwordNAS;

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

                File.WriteAllBytes(finalDestino, oDocument);
                
            }
            catch (Exception e)
            {

                //MessageBox.Show("Sin archivo de pdf");
                //btnAbrir.Enabled = true;
                //btnGuardar.Enabled = true;
            }
        }
        public void crearCarpetaEmision(string nuevaRuta)
        {
            setNasConnection();
            try
            {
                FtpWebRequest reqFTP = null;
                Stream ftpStream = null;
                reqFTP = (FtpWebRequest)WebRequest.Create(nuevaRuta);
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_userNAS, _passwordNAS);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("No creada");
            }


        }

        public async Task VerificarYCrearCarpeta(string rutaCarpeta)
        {
            setNasConnection();
            try
            {
                FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(rutaCarpeta);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.Credentials = new NetworkCredential(_userNAS, _passwordNAS);

                using (FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse())
                {
                    // Si la respuesta es positiva, la carpeta existe
                    //Console.WriteLine("La carpeta existe");
                }
            }
            catch (WebException ex)
            {
                // Si la excepción indica que la carpeta no existe, intentamos crearla
                if (ex.Response != null && ((FtpWebResponse)ex.Response).StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    //Console.WriteLine("La carpeta no existe. Creándola...");
                    CrearCarpetaFTP(rutaCarpeta);
                }
                else
                {
                    // Otra excepción que no sea por carpeta no encontrada
                    Console.WriteLine("Error al verificar la carpeta: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
        }

        public void CrearCarpetaFTP(string nuevaRuta)
        {
            setNasConnection();
            try
            {
                FtpWebRequest reqFTP = (FtpWebRequest)WebRequest.Create(nuevaRuta);
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_userNAS, _passwordNAS);

                using (FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse())
                {
                    Console.WriteLine("Carpeta creada con éxito");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la carpeta: " + ex.Message);
            }
        }


        private async Task crearArchivo(Stream origen, Stream destino)
        {

            byte[] buffer = new byte[1024];
            int bytesLeidos = await origen.ReadAsync(buffer, 0, 1024);
            double total = (double)origen.Length;
            int byteRead = 0;
            double read = 0;
            while (bytesLeidos != 0)
            {


                    await destino.WriteAsync(buffer, 0, bytesLeidos);
                    bytesLeidos = await origen.ReadAsync(buffer, 0, 1024);
                    read += (double)byteRead;
                    

            }

            origen.Close();
            destino.Close();
        }




    }
}
