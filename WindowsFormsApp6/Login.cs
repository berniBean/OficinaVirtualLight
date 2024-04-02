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
using WindowsFormsApp6.CAD.BLL;

namespace WindowsFormsApp6
{
    public partial class Login : Form
    {

        public int id;
        private ErrorProvider ProveerdorDeError = new ErrorProvider();
        private CDiasLaboralesBLL bdDias = new CDiasLaboralesBLL();

        public Login()
        {
            InitializeComponent();
            txtUser.MaxLength = 10;
            txtPass.MaxLength = 5;
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


        private void btnLog_Click(object sender, EventArgs e)
        {       
                if (txtUser.Text != "USUARIO")
                {
                    if (txtPass.Text != "CONTRASEÑA")
                    {
                    CUsuarioSupBLL usuario = new CUsuarioSupBLL();
                    var validLogin = usuario.LoginUser(txtUser.Text, txtPass.Text);
                    
                    if (validLogin == true)
                    {
                        FormPadrePrincipal mainMenu = new FormPadrePrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                        cargarDiasCalendarioAsync().Wait();

                    }
                    else {
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
            
        }

        private async Task cargarDiasCalendarioAsync()
        {
            var listado = await bdDias.GetDiasFestivosAsync();
            CUserLoggin.DiasFestivos = listado;
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
