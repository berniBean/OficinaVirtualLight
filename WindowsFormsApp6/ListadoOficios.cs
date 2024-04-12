using CleanArchitecture.Concretas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Helper.DataGridHelper;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6
{
    public partial class ListadoOficios : Form
    {
        private string _emision;
        
        private obtenerOficiosSQL obtenerOficiosSQL;
        private ListCOficios oficios;
        private FechaOficiosDAL oficiosDAL;
        private ListFechaOficios ListFechaOficios;
        private CargarFechasOficios cargarFechasOficios;

        public ListadoOficios(string emision, int tipoS)
        {
            InitializeComponent();
            _emision = emision;



            oficiosDAL = new FechaOficiosDAL();
            if (tipoS == 1|| tipoS == 3)
            {
                obtenerOficiosSQL = OficiosFactory.maker(OficiosFactory.RIF);
            }

            if(tipoS == 2|| tipoS == 4)
            {
                obtenerOficiosSQL = OficiosFactory.maker(OficiosFactory.PLUS);
            }
            cargarFechasOficios= new CargarFechasOficios(fechaOficiosBindingSource);



            cargarTableroListadoRequeridos().Wait();
            cargarFechas().Wait();
        }

        private async Task cargarFechas()
        {

            cargarFechasOficios.FechasBs.DataSource = await cargarFechasOficios.GetFechasOficios(_emision);

        }



        private async Task cargarTableroListadoRequeridos()
        {
            oficios = await obtenerOficiosSQL.listadoOficiosSql(_emision);
            cOficiosBOBindingSource.DataSource = oficios;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var paso = new fechaOficios();

            paso.IdEmision = _emision;
            paso.FechaOficios = paso.FormantFechas(dtpOficio.Text);
            




            cargarFechasOficios.SetFechaOficio(paso);
            await new CargaNumOficios(tsProgressOficio, obtenerOficiosSQL).oficioModificador(oficios);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.Control && e.KeyCode == Keys.C)
                GridHelper<ListCOficios>.CopiarPortapapeles(dataGridView1);

            if (e.Control && e.KeyCode == Keys.V)
            {
                
                GridHelper<ListCOficios>.pegar_portapapeles(dataGridView1, CalendarioVacacional, oficios);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 
