using App_VerFormsAPI;
using App_VerFormsAPI.Strategy.Concretas;
using App_VerFormsAPI.Strategy;
using RestSharp;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class RequerimientosControl : UserControl
    {

        private string url = System.Configuration.ConfigurationManager.AppSettings["ASP_BASE_URL"];
        private class Datos
        {
            public string pathCatalogo { get; set; }
            public string pathOmisos { get; set; }

            public string ReferenciaEmision { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaRetroAlimentacion { get; set; }
            public int Ejercicio { get; set; }
            public string OficioSat { get; set; }
            public string DetalleEmision { get; set; }
            public double UltimoRegistro { get; set; }

        }

        public RequerimientosControl()
        {
            InitializeComponent();
        }

        private void RequerimientosControl_Load(object sender, EventArgs e)
        {
            lblCatalogo.Text = string.Empty;
            lblOmisos.Text = string.Empty;

            LstResultados.View = View.Details; // Modo detalles
            LstResultados.FullRowSelect = true;
            LstResultados.GridLines = true;
            LstResultados.Dock = DockStyle.Fill; // Para ocupar todo el formulario
        }



        #region operaciones insert
        private async Task<RestResponse> NuevoCatalogo(Datos dto)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/Catalogo");

            var body = new
            {
                idEmision = 0,
                rutaNvc = dto.pathCatalogo
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;

        }

        private async Task<RestResponse> AgregarDireccionesOmisosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/Direcciones/nuevasdirecciones");

            var body = new
            {
                path = dto.pathOmisos
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;
        }

        private async Task<RestResponse> ActualizarDireccionesOmisosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/Direcciones/actualizardirecciones");

            var body = new
            {
                path = dto.pathOmisos
            };

            var response = await RequestGenerico.PutBodyAsync(sb.ToString(), body);
            return response;
        }

        private async Task<RestResponse> AgregarRegistroControlRequerimientosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/ControlPlus/agregarRegistro");

            var body = new
            {
                idEmision = 0,
                referenciaEmision = dto.ReferenciaEmision,
                fechaEmision = dto.FechaEmision,
                fechaRetroAlimentacion = dto.FechaRetroAlimentacion,
                ejercicio = dto.Ejercicio,
                oficioSat = dto.OficioSat,
                detalleEmision = dto.DetalleEmision
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;
        }

        private async Task<RestResponse> AgregarRegistrosListadoRequerimientosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/ListadoRequerimiento/nuevolistado");

            var body = new
            {
                path = dto.pathOmisos
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;
        }

        private async Task<RestResponse> AgregarRegistrosRequerimientosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/Requerimientos/nuevaEmision");

            var body = new
            {
                path = dto.pathOmisos,
                consecutivoRequerimiento = dto.UltimoRegistro
            };

            var response = await RequestGenerico.PostAsync(sb.ToString(), body);
            return response;
        }

        private async Task<RestResponse> AtualizaNumeracionRegistrosListadoRequerimientosAsync(Datos dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("/api/ListadoRequerimiento/actualizalistado");

            var response = await RequestGenerico.PutAsync(sb.ToString());
            return response;
        }
        #endregion


        #region OpInternas
        private string ConfigOpenDialog(Button text)
        {
            string res = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurar propiedades del diálogo
                openFileDialog.Filter = "Archivos de texto (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 1; // Por defecto, selecciona el primer filtro
                openFileDialog.RestoreDirectory = true; // Restaura el directorio inicial al cerrar el diálogo

                // Mostrar el diálogo y verificar si el usuario hizo clic en "Aceptar"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = openFileDialog.FileName;

                    // Mostrar la ruta del archivo en el TextBox
                    if (text.Name == "BtnCatalogo")
                    {
                        lblCatalogo.Text = filePath;
                        res = filePath;
                    }

                    if (text.Name == "BtnOmisos")
                    {
                        lblOmisos.Text = filePath;
                        res = filePath;
                    }


                }
                return res;
            }
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            ConfigOpenDialog(clickedButton);
        }

        private void BtnOmisos_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            ConfigOpenDialog(clickedButton);
        }
        #endregion




        private async void BtnEjecutar_Click(object sender, EventArgs e)
        {
            var dto = new Datos()
            {
                pathCatalogo = lblCatalogo.Text,
                pathOmisos = lblOmisos.Text,
                ReferenciaEmision = txtNombreEmisión.Text,
                FechaEmision = DateTime.Parse(DtFechaEmision.Value.ToShortDateString()),
                FechaRetroAlimentacion = DateTime.Parse(DtFechaRetro.Value.ToShortDateString()),
                Ejercicio = Convert.ToInt16(TbEjercicio.Text),
                OficioSat = txtOficioSat.Text,
                DetalleEmision = txtDetalleEmision.Text,
                UltimoRegistro = Convert.ToDouble(txtUltimoReq.Text)

            };

            try
            {
                BtnEjecutar.Enabled = false;
                LstResultados.Items.Clear();

                LstResultados.Columns.Add("Proceso", 150);
                LstResultados.Columns.Add("Resultado", 250);

                var procesar = new ProcesadorRespuestas(null);



                var resNuevoCatalogo = await NuevoCatalogo(dto);
                procesar.EstablecerEstrategia(new CatalogoResponseStrategy());
                procesar.Procesar(resNuevoCatalogo, LstResultados);

                var resActualizar = await ActualizarDireccionesOmisosAsync(dto);
                procesar.EstablecerEstrategia(new ActualizaDireccionesStrategy());
                procesar.Procesar(resActualizar, LstResultados);

                var resDirecciones = await AgregarDireccionesOmisosAsync(dto);
                procesar.EstablecerEstrategia(new DireccionesResponseStrategy());
                procesar.Procesar(resDirecciones, LstResultados);

                var resNuevoControl = await AgregarRegistroControlRequerimientosAsync(dto);
                procesar.EstablecerEstrategia(new AgregarRegistroControlRequerimientosStrategy());
                procesar.Procesar(resNuevoControl, LstResultados);

                var res = await AgregarRegistrosListadoRequerimientosAsync(dto);
                procesar.EstablecerEstrategia(new AgregarRegistrosListadoRequerimientosStrategy());
                procesar.Procesar(res, LstResultados);

                var resAgregarRequerimientos = await AgregarRegistrosRequerimientosAsync(dto);
                procesar.EstablecerEstrategia(new AgregarRegistrosRequerimientosStrategy());
                procesar.Procesar(resAgregarRequerimientos, LstResultados);

                var resActNum = await AtualizaNumeracionRegistrosListadoRequerimientosAsync(dto);
                procesar.EstablecerEstrategia(new AtualizaNumeracionRegistrosListadoRequerimientosStrategy());
                procesar.Procesar(resActNum, LstResultados);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                BtnEjecutar.Enabled = true;
            }
        }


    }
}
