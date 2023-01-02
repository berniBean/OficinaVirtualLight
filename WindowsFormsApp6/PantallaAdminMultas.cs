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
    public partial class PantallaAdminMultas : Form
    {
        private CListaTableroAdmin listTablero;

        private CTableroAdminBO obTablero = new CTableroAdminBO();
        obtenerTableroSup tableroSuper;
        obtenerTableroSup cmbFiscal;
        int tipoSesion;

        private CanhoFiscalBLL bd = new CanhoFiscalBLL();
        private CanhoFiscalBO obListaAnho = new CanhoFiscalBO();
        obtenerPeriodoFiscal obListYear;
        
        public PantallaAdminMultas(int tipo)
        {
            tipoSesion = tipo;
            InitializeComponent();
            if(tipo == 1)
            {
                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                cargarEjercicioFiscal();

                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.RIF);
                obListYear = factoryYear.maker(factoryYear.RIF);
                CargarTablero();
            }

            if(tipo == 2)
            {
                cmbFiscal = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                cargarEjercicioFiscal();

                tableroSuper = factoryTableroSupervisor.maker(factoryTableroSupervisor.PLUS);
                obListYear = factoryYear.maker(factoryYear.PLUS);
                CargarTablero();
            }
        }

        private async void CargarTablero()
        {
            
            dataGridView1.DataSource = await tableroSuper.TableroMultasAdmin(Convert.ToInt32(cmbEjercicio.Text));
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void cargarEjercicioFiscal()
        {
            cmbEjercicio.DataSource = await cmbFiscal.GetEjerciciosFisales();
        }

        private void cmbEjercicio_Leave(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                int emision;
                emision = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                AvanceGeneralMultasAdmin admin = new AvanceGeneralMultasAdmin(emision, tipoSesion);
                admin.Show();
            }

            if (e.ColumnIndex == 2)
            {
                int emision;
                emision = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                ListadoMultados admin = new ListadoMultados(emision, tipoSesion);
                admin.Show();
            }

            if (e.ColumnIndex == 3)
            {
                int emision;
                int año;
                string nombreEmision;

                emision = Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                año = Convert.ToInt16(cmbEjercicio.Text);
                nombreEmision = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                PantallaConcentradoOficosMULTAS GestorOficios = new PantallaConcentradoOficosMULTAS(emision, nombreEmision, tipoSesion);
                GestorOficios.Show();
            }
        }
    }
}
