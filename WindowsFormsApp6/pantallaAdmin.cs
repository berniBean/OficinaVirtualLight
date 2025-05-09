using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6.BLL;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6
{
    public partial class pantallaAdmin : Form
    {
        //private CTableroAdminBLL bd = new CTableroAdminBLL();
        //private CTableroAdminBO obTablero = new CTableroAdminBO();
        private CListaTableroAdmin listTablero;
        private CEmisionActualDALPLUs cEmisionActualDALPLUs = new CEmisionActualDALPLUs();
        private CTableroAdminBO obTablero = new CTableroAdminBO();
        obtenerTableroSup tableroSuper;
        obtenerTableroSup cmbFiscal;
        int tipoSesion;

        private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        private CanhoFiscalBO obListaAnho = new CanhoFiscalBO();
        obtenerPeriodoFiscal obListYear;
        public pantallaAdmin(int tipo)
        {
            InitializeComponent();
            tipoSesion = tipo;
            if (tipo == 1 || tipo ==3)
            {

                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                cargarEjercicioFiscal();

                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                obListYear = factoryYear.maker(factoryYear.RIF);
                CargarTablero();


            }

            if (tipo == 2 || tipo ==4)
            {

                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                cargarEjercicioFiscal();

                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                obListYear = factoryYear.maker(factoryYear.PLUS);
                CargarTablero();


            }
            
            //dgTableroAdmin.AutoResizeColumns();
            //dgTableroAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private async void  CargarTablero()
        {
            if (tipoSesion == 1 ) 
            {
                dataGridView1.DataSource = await tableroSuper.Tablero(Convert.ToInt32(cmbEjercicio.Text));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            }
            if (tipoSesion == 2)
            {
                dataGridView1.DataSource = await tableroSuper.Tablero(Convert.ToInt32(cmbEjercicio.Text));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (tipoSesion == 3)
            {
                dataGridView1.DataSource = await tableroSuper.TableroMultasAdmin(Convert.ToInt32(cmbEjercicio.Text));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            if (tipoSesion == 4) 
            {
                dataGridView1.DataSource = await tableroSuper.TableroMultasAdmin(Convert.ToInt32(cmbEjercicio.Text));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private async void cargarEjercicioFiscal()
        {
            cmbEjercicio.DataSource = await cmbFiscal.GetEjerciciosFisales();

            var listado = cEmisionActualDALPLUs.GetPeriodo(cmbEjercicio.Text);
            CUserLoggin.FechasEmision = listado;
        }



        private void dgTableroAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreEmision;
            int emision;
            nombreEmision = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            emision = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            CUserLoggin.DetalleEmision = CUserLoggin.FechasEmision.FirstOrDefault(x => x.NomEmision.Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
            if (e.ColumnIndex == 4)
            {

                
                //mostrar avance de oficina
                AvanceGeneral general = new AvanceGeneral(emision,nombreEmision, tipoSesion);
                general.Show();
            }

            if(e.ColumnIndex == 5)
            {
                
                //mostrar listado completo requerimientos

                ListadoRequeridos general = new ListadoRequeridos(emision,nombreEmision , tipoSesion);
                general.Show();
            }
            //para concentrado oficios
            if(e.ColumnIndex == 6)
            {

                int año;
             

                
                año = Convert.ToInt16(cmbEjercicio.Text);               
                PantallaConcentradoOficios GestorOficios = new PantallaConcentradoOficios( CUserLoggin.zonaSupervisor,emision, nombreEmision, tipoSesion);
                GestorOficios.Show();
            }
        }

        private void cmbEjercicio_Leave(object sender, EventArgs e)
         {
            var listado = cEmisionActualDALPLUs.GetPeriodo(cmbEjercicio.Text);
            CUserLoggin.FechasEmision = listado;
            CargarTablero();
        }

        private void pantallaAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
