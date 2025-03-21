using System;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class FormPadrePrincipal : Form
    {
        

        public FormPadrePrincipal()
        {
            InitializeComponent();

           
            if (CUserLoggin.nombreSup.Contains("BerniP")) 
            {
                
                capturaReqRIF.Visible = true;
                capturaMultasRIF.Visible = true;
                avanceReqPLUS.Visible = true;
                caputraReqPLUS.Visible = true;
                capturaMultaPLUS.Visible = true;

                capturaOficiosRIF.Visible = true;
                capturaOficiosPLUS.Visible = true;
            }

            if (CUserLoggin.nombreSup.Contains("RCO"))
            {
                
                
                capturaReqRIF.Visible = false;
                capturaMultasRIF.Visible = false;
                avanceReqPLUS.Visible = false;
                caputraReqPLUS.Visible = false;
                capturaMultaPLUS.Visible = false;




                requerimientosPLUSToolStripMenuItem.Visible = true;
                multasPLUSToolStripMenuItem.Visible = true;
                capturaOficiosRIF.Visible = true;
                capturaOficiosPLUS.Visible = true;


            }


            requerimientosPLUSToolStripMenuItem.Visible = true;
            multasPLUSToolStripMenuItem.Visible = true;
            JefeRif_Item.Visible = true;
            MultasRIF_Item.Visible = true;





        }

        private void menuAvance_Click(object sender, EventArgs e)
        {
            Form2 formAvance = new Form2(1);
            formAvance.MdiParent = this;
            formAvance.Show();
        }
        private void avanceReqPLUS_Click(object sender, EventArgs e)
        {
            Form2 formCaptura = new Form2(2);

            formCaptura.MdiParent = this;
            formCaptura.Show();

        }
        private void capturaReqRIF_Click(object sender, EventArgs e)
        {

            Form1 formCaptura = new Form1(1);

            formCaptura.MdiParent = this;
            formCaptura.Show();
        }
        private void caputraReqPLUS_Click(object sender, EventArgs e)
        {
            Form1 formCaptura = new Form1(2);
            CUserLoggin.tipoVentana = "Requerimientos";
            formCaptura.MdiParent = this;
            formCaptura.Show();
        }

        private void capturaMultasRIF_Click(object sender, EventArgs e)
        {

            PantallaMultasPendientes formMultas = new PantallaMultasPendientes(1);
            formMultas.MdiParent = this;
            formMultas.Show();
        }

        private void capturaMultaPLUS_Click(object sender, EventArgs e)
        {
            PantallaMultasPendientes formMultas = new PantallaMultasPendientes(2);
            CUserLoggin.tipoVentana = "Multas";
            formMultas.MdiParent = this;
            formMultas.Show();
        }




        private void busquedaRIF_Click(object sender, EventArgs e)
        {
            Form5 formBusqueda = new Form5(tipoSesion.RIF);
            formBusqueda.MdiParent = this;
            formBusqueda.Show();
        }




        private void busquedaPLUS_Click(object sender, EventArgs e)
        {
            Form5 formBusqueda = new Form5(tipoSesion.PLUS);
            formBusqueda.MdiParent = this;
            formBusqueda.Show();
        }

        private void requerimientosPLUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallaAdmin admin = new pantallaAdmin(tipoSesion.PLUS);
            admin.Text = "Informes avance requerimientos PLUS";
            CUserLoggin.tipoVentana = "Requerimientos";
            admin.MdiParent = this;
            admin.Show();
        }

        private void JefeRif_Item_Click(object sender, EventArgs e)
        {
            pantallaAdmin admin = new pantallaAdmin(tipoSesion.RIF);
            admin.MdiParent = this;
            admin.Show();
        }
        private void MultasRIF_Item_Click(object sender, EventArgs e)
        {
            PantallaAdminMultas admin = new PantallaAdminMultas(tipoSesion.RIF);
            admin.MdiParent = this;
            admin.Show();
        }
        private void multasPLUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaAdminMultas admin = new PantallaAdminMultas(tipoSesion.PLUS);
            admin.Text = "Informes avance multas PLUS";
            CUserLoggin.tipoVentana = "Multas";
            admin.MdiParent = this;
            admin.Show();
        }
        //1oficios 
        //2pdf 

        private void capturaOficioRequerimientoPLUS_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.PLUS, tipoGestion.oficio);
            admin.Text = "Capturar oficios requerimientos";
            admin.MdiParent = this;
            admin.Show();

        }
        private void tsCapturaOficiosMulta_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.MPLUS, tipoGestion.oficio);
            admin.Text = "Capturar oficios multas";
            admin.MdiParent = this;
            admin.Show();
        }

        private void tsOficiosReqRIF_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.RIF, tipoGestion.oficio);
            admin.MdiParent = this;
            admin.Show();
        }

        private void tsOficiosMultasRIF_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.RIF, tipoGestion.oficio);
            admin.MdiParent = this;
            admin.Show();
        }

        private void requerimientosPDFRIF_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.RIF, tipoGestion.pdf);
            admin.MdiParent = this;
            admin.Show();
        }

        private void requerimientosPDFPLUS_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.PLUS, tipoGestion.pdf);
            CUserLoggin.tipoVentana = "Requerimientos";
            admin.Text = "Cargar documentos requerimientos";
            admin.MdiParent = this;
            admin.Show();
        }

        private void multasPDFPLUS_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.MPLUS, tipoGestion.pdf);
            CUserLoggin.tipoVentana = "Multas";
            admin.Text = "Cargar documentos multas";
            admin.MdiParent = this;
            admin.Show();
        }

        private void multasPDFRIF_Click(object sender, EventArgs e)
        {
            selectorOficios admin = new selectorOficios(tipoSesion.MRIF, tipoGestion.pdf);
            admin.MdiParent = this;
            admin.Show();
        }

        private void menuAgenda_Click(object sender, EventArgs e)
        {
            Directorio MeDir = new Directorio();
            MeDir.MdiParent = this;
            MeDir.Show();
        }

        private void notificadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditaNotificadores Notificadores = new EditaNotificadores();
            Notificadores.MdiParent = this;
            Notificadores.Show();
        }

        private void cargaPDFPLUS_Click(object sender, EventArgs e)
        {

        }

        private void crearEmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorCreador form = new FormEditorCreador();
            form.MdiParent= this;
            form.Show();    
        }























        //private void menuCaptura_Click(object sender, EventArgs e)
        //{

        //    Form1 formCaptura = new Form1();

        //    formCaptura.MdiParent = this;
        //    formCaptura.Show();
        //}

        //private void menuListados_Click(object sender, EventArgs e)
        //{
        //    Form3 formListadosRif = new Form3();
        //    formListadosRif.MdiParent = this;
        //    formListadosRif.Show();
        //}

        //private void  menuBusquedaMasiva_Click(object sender, EventArgs e)
        //{
        //    Form5 formBusquedaDatos = new Form5();
        //    formBusquedaDatos.MdiParent = this;
        //    formBusquedaDatos.Show();
        //}

        //private void tableroToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    pantallaAdmin formAdmin = new pantallaAdmin();
        //    formAdmin.MdiParent = this;
        //    formAdmin.Show();
        //}

        //private void capturaMultasRIFToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    PantallaMultasPendientes formMultas = new PantallaMultasPendientes();
        //    formMultas.MdiParent = this;
        //    formMultas.Show();
        //}

    }
}
