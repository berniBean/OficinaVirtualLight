using App_VerFormsAPI;
using App_VerFormsAPI.DTO;
using App_VerFormsAPI.Strategy;
using App_VerFormsAPI.Strategy.ConcretasJSON;
using RestSharp;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class EliminaRequerimientoControl1 : UserControl
    {

        private string url = System.Configuration.ConfigurationManager.AppSettings["ASP_BASE_URL"];
        private int _numemision;

        private class Dato
        {
            public int Ejercicio { get; set; }
        }

        public EliminaRequerimientoControl1()
        {
            InitializeComponent();
        }

        private void EliminaRequerimientoControl1_Load_1(object sender, EventArgs e)
        {
            LstResultados.View = View.Details;
            LstResultados.FullRowSelect = true;
            LstResultados.GridLines = true;
            LstResultados.Dock = DockStyle.Fill; // Para ocupar todo el formulario
            LstResultados.Columns.Add("Proceso", 150);
            LstResultados.Columns.Add("Estatus", 150);

            label3.Text = string.Empty;
        }





        private async Task<RestResponse> EliminarRequerimientos() 
        {



            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/Requerimientos/emisonRequerimientoDelete");


            RestResponse response;
            var body = new
            {
                IdEmison = _numemision
            };

            if (body.IdEmison != 0) 
            { 
                 response = await RequestGenerico.DeleteAsync(sb.ToString(), body);

                
            
                return response;
            }
            else
            {
                

                MessageBox.Show("Debes seleccionar emision primero");
                return null;
            }



        }

        private async Task<RestResponse> GetTableroRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/ControlPlus/verRegistros");


            var body = new
            {
                ejercicio = TbEjercicio.Text
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);

            return response;    
        }

        private async void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                btnEjecutar.Enabled = false;
                LstResultados.Items.Clear();


                var procesar = new ProcesadorRespuestas(null);

                var resEliminar = await EliminarRequerimientos();
                procesar.EstablecerEstrategia(new EliminarRequerimientosStrategy());
                procesar.Procesar(resEliminar, LstResultados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                btnEjecutar.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if(TbEjercicio.Text=="")
            {
                MessageBox.Show("Deber introducir un año");
                return;
            }
            
            var api = new RespuestaHttpJson<DgEliminarDTO>(null);
            
            var RES = await GetTableroRequerimientos();
            api.EstablecerEstrategia(new ResponseJSonAsync());
            var list =api.Procesar(RES);
           


            dgControlReq.DataSource = list;
        }

        private void dgControlReq_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            else
            {
                _numemision = Convert.ToInt16( dgControlReq.CurrentRow.Cells[0].Value.ToString());
                string NomEmision = dgControlReq.CurrentRow.Cells[1].Value.ToString();
                string ReferenciaNumerica = dgControlReq.CurrentRow.Cells[2].Value.ToString();
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(NomEmision);
                stringBuilder.Append(ReferenciaNumerica);
                label3.Text = stringBuilder.ToString();

            }
        }


    }
}
