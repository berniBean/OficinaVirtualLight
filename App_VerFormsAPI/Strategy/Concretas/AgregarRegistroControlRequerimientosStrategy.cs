using App_VerFormsAPI.ResponseHttp;
using RestSharp;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy.Concretas
{
    public class AgregarRegistroControlRequerimientosStrategy : IResultHttpStrategy
    {
        public void ProcesarRespuesta(RestResponse respuesta, ListView listView)
        {
            if (respuesta.IsSuccessStatusCode)
            {
                listView.Items.Add(new ListViewItem(new[] { "Agrear Registro control", $"Exito, inserciones total:{respuesta.Content.ToString()}" }));
            }
            else
            {
                var res = new ErrorResponse
                {
                    StatusCode = (int)respuesta.StatusCode,
                    Message = respuesta.ErrorMessage ?? respuesta.StatusDescription
                };
                listView.Items.Add(new ListViewItem(new[] { "Agrear Registro control", $"Error:{res.Message}" }));
            }
        }
    }
}
