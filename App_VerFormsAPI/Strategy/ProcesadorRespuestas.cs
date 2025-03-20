using RestSharp;
using System.Net.Http;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy
{
    public class ProcesadorRespuestas
    {
        private IResultHttpStrategy _respuestaStrategy;


        //construsctor estategia inicial
        public ProcesadorRespuestas(IResultHttpStrategy respuestaStrategy)
        {
            _respuestaStrategy = respuestaStrategy;
        }

        //cambiar estategia
        public void EstablecerEstrategia(IResultHttpStrategy respuestaStrategy) 
        {
            _respuestaStrategy = respuestaStrategy;
        }

        public void Procesar(RestResponse respuesta, ListView listView)
        {
            _respuestaStrategy.ProcesarRespuesta(respuesta, listView);
        }
    }
}
