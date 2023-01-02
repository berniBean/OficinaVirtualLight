using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.BLL;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{

    public partial class selectorOficios : Form
    {
        private CListaTableroAdmin listTablero;

        private CTableroAdminBO obTablero = new CTableroAdminBO();
        obtenerTableroSup tableroSuper;
        obtenerTableroSup cmbFiscal;
        int tipoSesion;
        int _tipoGestion;
        

        private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        private CanhoFiscalBO obListaAnho = new CanhoFiscalBO();
        obtenerPeriodoFiscal obListYear;
        public selectorOficios(int tipo, int tipoGestion)
        {
            InitializeComponent();
            tipoSesion = tipo;
            _tipoGestion = tipoGestion;

            //gestion de Oficios
            if (tipoGestion ==1) 
            {
                //rif
                if (tipoSesion == 1)
                {

                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    obListYear = factoryYear.maker(factoryYear.RIF);
                    CargarTablero().Wait();


                }
                //plus
                if (tipoSesion == 2)
                {

                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    obListYear = factoryYear.maker(factoryYear.PLUS);
                    CargarTablero().Wait();


                }
                //multas RIF
                if(tipoSesion == 3)
                {
                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    obListYear = factoryYear.maker(factoryYear.RIF);
                    CargarTableroMultaPLUS().Wait();

                }

                //multas PLUS
                if (tipoSesion == 4)
                {

                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    obListYear = factoryYear.maker(factoryYear.PLUS);
                    CargarTableroMultaPLUS().Wait();
                }




            }

            //gestion pdf
            if(tipoGestion == 2)
            {
                //pdfRequerimientosRIF
                if (tipoSesion == 1) 
                {
                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    obListYear = factoryYear.maker(factoryYear.RIF);
                    CargarTablero().Wait();
                }
                //pdfRequerimientosPLUS
                if (tipoSesion == 2)
                {
                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    obListYear = factoryYear.maker(factoryYear.PLUS);
                    CargarTablero().Wait();
                }
                //pdfMultaRIF
                if (tipoSesion == 3)
                {

                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                    obListYear = factoryYear.maker(factoryYear.RIF);
                    CargarTableroMultaPLUS().Wait();


                }
                //pdfMultaPLUS
                if (tipoSesion == 4)
                {
                    cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    cargarEjercicioFiscal().Wait();

                    tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                    obListYear = factoryYear.maker(factoryYear.PLUS);
                    CargarTableroMultaPLUS().Wait();
                }

            }


        }

        private async Task CargarTableroMultaPLUS()
        {

            listTablero =  await tableroSuper.TableroMultasAdmin(Convert.ToInt32(cmbEjercicio.Text));
            dgReqPLUS.DataSource =listTablero;
            dgReqPLUS.AutoResizeColumns();
            dgReqPLUS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async Task CargarTablero()
        {
            listTablero = await tableroSuper.Tablero(Convert.ToInt32(cmbEjercicio.Text));
            dgReqPLUS.DataSource = listTablero;
            dgReqPLUS.AutoResizeColumns();
            dgReqPLUS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async Task cargarEjercicioFiscal()
        {
            cmbEjercicio.DataSource = await cmbFiscal.GetEjerciciosFisales();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string emision;
            int emisionInt;
            if(_tipoGestion == 1)
            {

                if (e.ColumnIndex == 2)
                {
                    //requerimientos
                    if (tipoSesion == 1 || tipoSesion == 2)
                    {
                        emision = dgReqPLUS.CurrentRow.Cells[1].Value.ToString();
                        ListadoOficios admin = new ListadoOficios(emision, tipoSesion);
                        admin.ShowDialog();
                    }

                    //Multas
                    if(tipoSesion == 3 || tipoSesion == 4)
                    {
                        emision = dgReqPLUS.CurrentRow.Cells[0].Value.ToString();
                        ListadoOficios admin = new ListadoOficios(emision, tipoSesion);
                        admin.ShowDialog();
                    }

                }

            }


            if(_tipoGestion == 2)
            {
                if (e.ColumnIndex == 2)
                {
                    
                    int año;
                    string nombreEmision;

                    emisionInt = Convert.ToInt16(dgReqPLUS.CurrentRow.Cells[2].Value.ToString());
                    año = Convert.ToInt16(cmbEjercicio.Text);
                    nombreEmision = dgReqPLUS.CurrentRow.Cells[1].Value.ToString();
                    DragDropPDF gestorPDF = new DragDropPDF(emisionInt, tipoSesion, año, nombreEmision);
                    gestorPDF.Show();
                }
            }

        }

        private async void cmbEjercicio_Leave(object sender, EventArgs e)
        {
            if(tipoSesion == 1 || tipoSesion == 2)
                await CargarTablero();
            if (tipoSesion == 3 || tipoSesion == 4)
                await CargarTableroMultaPLUS();
        }

        private void selectorOficios_Load(object sender, EventArgs e)
        {

        }
    }
}
