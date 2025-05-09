using App_VerFormsAPI;
using App_VerFormsAPI.DTO;
using App_VerFormsAPI.Helpers;
using RestSharp;
using System;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.DAL;

namespace WindowsFormsApp6
{
    public partial class Login : Form
    {

        
        private ErrorProvider ProveerdorDeError = new ErrorProvider();
        private CDiasLaboralesBLL bdDias = new CDiasLaboralesBLL();
        private CatObservacionesDAL catalogo = new CatObservacionesDAL();
        private CNotificadoresDAL CatalogoNotificadores = new CNotificadoresDAL();
        private CEmisionActualDALPLUs cEmisionActualDALPLUs = new CEmisionActualDALPLUs();

        private string url = System.Configuration.ConfigurationManager.AppSettings["ASP_BASE_URL"];


        private class Datos
        {
            public string userName;
            public string password;
        }


        private async Task<RestResponse> GetAuthUserAsync(Datos dt) 
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/UserAuth/login");

            var body = new
            {
                UserName = dt.userName,
                Password = dt.password
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;
        }



        public Login()
        {
            InitializeComponent();
            txtUser.MaxLength = 25;
            txtPass.MaxLength = 25;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO") {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;


            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA") {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
                
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    Datos dt = new Datos();
                    dt.userName = txtUser.Text;
                    dt.password = txtPass.Text;

                    var response = await GetAuthUserAsync(dt);

                    if (response.IsSuccessful) 
                    { 
                        var result = JsonSerializer.Deserialize<ApiLoginResponse>(response.Content, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        string token = result?.Token;

                       var resul= JwtHelper.ConvetToken(token);

                        resul.Claims.ForEach(x =>
                        {
                            
                            
                            if (x.Item1 == "email")
                            {
                               CUserLoggin.Email = x.Item2;
                            }
                            if (x.Item1 == "name")
                            {
                                CUserLoggin.nombreSup = x.Item2;
                            }
                            if (x.Item1 == "zona")
                            {
                                CUserLoggin.zonaSupervisor = x.Item2;
                            }
                            if (x.Item1 == "role")
                            {
                                CUserLoggin.Rol = x.Item2;
                            }
                        });

                        FormPadrePrincipal mainMenu = new FormPadrePrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                        cargarDiasCalendarioAsync().Wait();
                        CatObservaciones();
                        ListadoNotificador();

                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrectos");
                        txtUser.Text = "USUARIO";
                        txtPass.Text = "CONTRASEÑA";
                        txtPass.UseSystemPasswordChar = false;
                        btnLog.Focus();
                    }
                }
                else msgError("Ingrese su Contraseña");
            }
            else msgError("Ingrese su Usuario");

            //if (txtUser.Text != "USUARIO")
            //{
            //    if (txtPass.Text != "CONTRASEÑA")
            //    {
            //CUsuarioSupBLL usuario = new CUsuarioSupBLL();
            //var validLogin = usuario.LoginUser(txtUser.Text, txtPass.Text);

            //    if (validLogin == true)
            //    {
            //        FormPadrePrincipal mainMenu = new FormPadrePrincipal();
            //        mainMenu.Show();
            //        mainMenu.FormClosed += Logout;
            //        this.Hide();
            //        cargarDiasCalendarioAsync().Wait();
            //        CatObservaciones();
            //        ListadoNotificador();

            //    }
            //    else {
            //        msgError("Usuario o Contraseña incorrectos");
            //        txtUser.Text = "USUARIO";
            //        txtPass.Text = "CONTRASEÑA";
            //        txtPass.UseSystemPasswordChar = false;
            //        btnLog.Focus();

            //    }


            //    }
            //    else msgError("Ingrese su Contraseña");

            //}

            //else msgError("Ingrese su Usuario");

        }

        private async Task cargarDiasCalendarioAsync()
        {
            var listado = await bdDias.GetDiasFestivosAsync();
            CUserLoggin.DiasFestivos = listado;
        }

        private void FechaEmision()
        {
            var listado = cEmisionActualDALPLUs.GetPeriodo("2024");
        }
        private  void CatObservaciones()
        {
            var listado = catalogo.GetCatObservacion();
            CUserLoggin.ListadoObservaciones = listado;
        }

        private void ListadoNotificador()
        {
            var listado = CatalogoNotificadores.GetListadoNotificadores();
            CUserLoggin.Notificadores = listado;
        }


        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e) {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            txtUser.Focus();

        }

    }
}
