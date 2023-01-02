using System;
using System.Windows.Forms;
using WindowsFormsApp6.BLL;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {

        private Login lg = new Login();
        private int datoID;
        private string temp;
        private int _tipo;

        //private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        obtenerPeriodoFiscal obAño;
        private ListCanhoFiscal listAnho;

        obtenerEmision obEmision;
        private ListCEmisionActual listPeriodo;

        obtenerNombreBimestre obNomBimestre;
        private ListaCNombreBimestre listNomBim;

        obtenerInformes obInformes;
        private CCCInformeAvanceBll bdAvance = new CCCInformeAvanceBll();
        private CInformeAvance obListaAvance = new CInformeAvance();
        private ListaInformeAvance listAvance;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int tipo)
        {

            InitializeComponent();
            _tipo = tipo;
            if (tipo == 1)//rif
            {
                obAño = factoryYear.maker(factoryYear.RIF);
                obEmision = factoryEmision.maker(factoryEmision.RIF);
                obNomBimestre = factoryNombreBimestre.maker(factoryNombreBimestre.RIF);
                obInformes = factoryInformes.maker(factoryInformes.RIF);
            }
            else if(tipo==2)//plus
            {
                obAño = factoryYear.maker(factoryYear.PLUS);
                obEmision = factoryEmision.maker(factoryEmision.PLUS);
                obNomBimestre = factoryNombreBimestre.maker(factoryNombreBimestre.PLUS);
                obInformes = factoryInformes.maker(factoryInformes.PLUS);
            }

        }

        private void CargarAnho()
        {
            try
            {
                //origen de los datos
                listAnho = obAño.listadoAños();//bd.GetCanho();
                canhoFiscalBOBindingSource.DataSource = listAnho;


            }
            catch (Exception ex)
            {
                
            }
        }

        //Realiza la carga de las emisiones totales
        private void CargarPeriodo()
        {
            try
            {
                //origen de los datos
                listPeriodo = obEmision.listadoEmisiones(cmbAnho.Text);//bdPeriodo.GetPeriodo(cmbAnho.Text);
                listCEmisionActualBindingSource.DataSource = listPeriodo;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void CargarNombreBimestre()
        {

            try
            {

                listNomBim = obNomBimestre.ListNombreBimestre(cmbAnho.Text, lblEmision.Text);//bdNombreBim.GetNombreEmisionInforme(cmbAnho.Text, lblEmision.Text);
                cNombreBimestreBOBindingSource.DataSource = listNomBim;


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void CargarRequerimientos()
        {

            try
            {
                listAvance = obInformes.AvancesReq(Convert.ToInt16(lblEmision.Text), datoID);//bdAvance.getAvancesRIF(Convert.ToInt16(lblEmision.Text), datoID);
                listaInformeAvanceBindingSource.DataSource = listAvance;
            }
            catch (Exception)
            {

               
            }



        }

        private void cmbAnho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CargarPeriodo();
                CargarNombreBimestre();
                CargarRequerimientos();
                dgAvance.AutoResizeColumns();
                dgAvance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void CmbAnho_Leave(object sender, EventArgs e)
        {
            CargarPeriodo();
            CargarNombreBimestre();
            CargarRequerimientos();
            dgAvance.AutoResizeColumns();
            dgAvance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cmbEmision_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                CargarPeriodo();
                CargarNombreBimestre();
                CargarRequerimientos();
                dgAvance.AutoResizeColumns();
                dgAvance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }

        private void CmbEmision_Leave(object sender, EventArgs e)
        {
            CargarRequerimientos();
            CargarNombreBimestre();
            dgAvance.AutoResizeColumns();
            dgAvance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            LodadUserDat();
            CargarAnho();
            CargarPeriodo();
            CargarRequerimientos();
            CargarNombreBimestre();
            cmbEmision.Focus();
        }



        private void LodadUserDat()
        {
            lblZonaName.Text = CUserLoggin.zonaSupervisor;
            datoID = CUserLoggin.idUser;

        }


    }
}
