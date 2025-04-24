using RestSharp;
using System.Collections.Generic;

namespace App_VerFormsAPI.Strategy
{
    public class RespuestaHttpJson<T>
    {
        private IResultHttpJson<T> _resultHttpJson;

        public RespuestaHttpJson(IResultHttpJson<T> respuestaStrategy)
        {
            _resultHttpJson = respuestaStrategy;
        }

        //cambiar estategia
        public void EstablecerEstrategia(IResultHttpJson<T> respuestaStrategy)
        {
            _resultHttpJson = respuestaStrategy;
        }

        public List<T> Procesar(RestResponse respuesta)
        {
           return _resultHttpJson.ResponseAsync(respuesta);
        }
    }
}
