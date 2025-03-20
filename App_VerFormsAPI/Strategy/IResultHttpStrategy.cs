using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy
{
    public interface IResultHttpStrategy
    {
        void ProcesarRespuesta(RestResponse respuesta, ListView listView);
    }
}
