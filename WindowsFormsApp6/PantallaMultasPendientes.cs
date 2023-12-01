using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Cache;
using WindowsFormsApp6.CAD.BLL;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;
using static WindowsFormsApp6.TableroMultasRIF;

namespace WindowsFormsApp6
{
    public partial class PantallaMultasPendientes : Form
    {
        
        private CListaTableroAdmin listTablero;
        private int supervisor;
        private int _tipo;        
        obtenerTableroSup cmbFiscal;
        obtenerTableroSup obTablero;

        ActualizarDelegado actualizarDelegado;




        public PantallaMultasPendientes(int tipo)
        {
            InitializeComponent();
            _tipo = tipo;
            
            if (tipo == 1)
            {
                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                cargarEjercicioFiscal().Wait();
                obTablero = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
            }
            else if (tipo == 2)
            {
                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                cargarEjercicioFiscal().Wait();
                obTablero = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
            }


            actualizarDelegado = new ActualizarDelegado(CargarTablero);
            supervisor = CUserLoggin.idUser;
            
            CargarTableroAsync().Wait();
            SetFormating();
            dgTableroMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private async Task cargarEjercicioFiscal()
        {
            cmbEjercicio.DataSource = await cmbFiscal.GetEjerciciosFisales();
        }

        private void CargarTablero()
        {
            CargarTableroAsync().Wait();
        }
        private async Task CargarTableroAsync()
        {
            try
            {
                listTablero = await obTablero.TableroMultasSupervisor(supervisor,Convert.ToInt32( cmbEjercicio.Text));//bd.GetGetTableroMultasSupervisor(supervisor);
                cListaTableroAdminBindingSource.DataSource = listTablero;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgTableroMultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            else
            {

                string _ejercicio = dgTableroMultas.Rows[e.RowIndex].Cells[0].Value.ToString();//ejercicio
                string dato = dgTableroMultas.Rows[e.RowIndex].Cells[1].Value.ToString();//Emision
                string _nombreEmision = dgTableroMultas.Rows[e.RowIndex].Cells[4].Value.ToString();//fechaEmision
                DateTime _FechaEmisionMultasRIF = Convert.ToDateTime(dgTableroMultas.Rows[e.RowIndex].Cells[4].Value.ToString());
                string totalEmitidos = dgTableroMultas.Rows[e.RowIndex].Cells[7].Value.ToString();
                string nombreEmisionMulta = dgTableroMultas.Rows[e.RowIndex].Cells[3].Value.ToString();
                string origenMultaRIF = dgTableroMultas.Rows[e.RowIndex].Cells[1].Value.ToString();
                CUserLoggin.idEmision = Convert.ToInt16(dato);
                CUserLoggin.Ejercicio = Convert.ToInt16(_ejercicio);
                CUserLoggin.nombreEmision = _nombreEmision;
                CUserLoggin.fechaEmisionMulta = _FechaEmisionMultasRIF;
                CUserLoggin.totalMultasEmitido = Convert.ToInt16(totalEmitidos);
                CUserLoggin.nombreEmisionMultaRIF = nombreEmisionMulta;
                CUserLoggin.origenMultaRIF = origenMultaRIF;
                
                if (_tipo == 1)
                {
                    TableroMultasRIF MultasRifSup = new TableroMultasRIF(1);
                    MultasRifSup.ejecutar += new TableroMultasRIF.ActualizarDelegado(CargarTablero);
                    MultasRifSup.Show();
                }
                    
                else if (_tipo == 2)
                {
                    TableroMultasRIF MultasRifSup = new TableroMultasRIF(2);
                    MultasRifSup.ejecutar += new TableroMultasRIF.ActualizarDelegado(CargarTablero);
                    MultasRifSup.Show();
                }
                

            }
            
        }
        private void SetFormating()
        {
            this.dgTableroMultas.Columns["_totalImporte"].DefaultCellStyle.Format = "C";
            this.dgTableroMultas.Columns["_honorarios"].DefaultCellStyle.Format = "C";
            
        }
        private void PantallaMultasPendientes_Load(object sender, EventArgs e)
        {

           
        }

        private void dgTableroMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private  void cmbEjercicio_Leave(object sender, EventArgs e)
        {
            CargarTableroAsync();
        }
    }
}
