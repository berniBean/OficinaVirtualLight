using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using WindowsFormsApp6.BLL;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {

        DataSetRIF ds = new DataSetRIF();
         string strConn;
        private int datoID;
        private string temp;

        

        private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        private CanhoFiscalBO obListaAnho = new CanhoFiscalBO();
        private ListCanhoFiscal listAnho;

        /// 
        /// </summary>
        private CEmisionActualBLL bdPeriodo = new CEmisionActualBLL();
        private CEmisionActualBO obListadoPeriodo = new CEmisionActualBO();
        private ListCEmisionActual listPeriodo;

        private CoheActivaBLL bdOHE = new CoheActivaBLL();
        private CoheActivaBO obListadoOHE = new CoheActivaBO();
        private ListCoheActiva listOHE;

        private CCNombreBimestreBLL bdNombreBim = new CCNombreBimestreBLL();
        private CNombreBimestreBO obListaNomBim = new CNombreBimestreBO();
        private ListaCNombreBimestre listNomBim;

        //actualizar Datos RIF
        private ListCoheActivaBLL bdReq = new ListCoheActivaBLL();
        private CListaRequeridosBO obListaRqe = new CListaRequeridosBO();
        private ListaClistaRequeridos listReq;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        //this.reportViewer1.RefreshReport();
            
            LodadUserDat();
            CargarAnho();
            
            CargarPeriodo();
            CargarOHE();
            CargarNombreBimestre();
            CargarRequerimientos();
            cargarReportView();


        }
        private void LodadUserDat()
        {
            lblZonaName.Text = CUserLoggin.zonaSupervisor;
            datoID = CUserLoggin.idUser;

        }
        private void CargarAnho()
        {
            try
            {
                //origen de los datos
                listAnho = bd.GetCanho();
                canhoFiscalBOBindingSource.DataSource = listAnho;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarPeriodo()
        {
            try
            {
                //origen de los datos
                listPeriodo = bdPeriodo.GetPeriodo(cmbAnho.Text);
                cEmisionActualBOBindingSource.DataSource = listPeriodo;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarOHE()
        {
            try
            {
                listOHE = bdOHE.GetOHE(Convert.ToString(datoID), cmbEmision.Text);
                listCoheActivaBindingSource.DataSource = listOHE;
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

                listNomBim = bdNombreBim.GetNombreEmision(cmbAnho.Text, cmbEmision.Text);
                listaCNombreBimestreBindingSource.DataSource = listNomBim;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarRequerimientos()
        {
            listReq = bdReq.GatReqGetRequerimientos(cmbEmision.Text, cmbOHE.Text);


        }

        private void cargarReportView() {
            

            ReportDataSource rds = new ReportDataSource("CListaRequeridosBO", listReq);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
        }
        private void cmbAnho_Leave(object sender, EventArgs e)
        {
            CargarPeriodo();
            CargarOHE();
            CargarRequerimientos();
            CargarNombreBimestre();
            cargarReportView();
        }

        private void cmbEmision_Leave(object sender, EventArgs e)
        {
            CargarPeriodo();
            CargarOHE();
            CargarRequerimientos();
            CargarNombreBimestre();
            cargarReportView();
        }

        private void cmbOHE_Leave(object sender, EventArgs e)
        {
            CargarPeriodo();
            CargarOHE();
            CargarRequerimientos();
            CargarNombreBimestre();
            cargarReportView();
        }


    }
}
