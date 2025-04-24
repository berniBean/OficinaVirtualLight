using App_VerFormsAPI.ResponseHttp;
using RestSharp;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy
{
    public class EliminarRequerimientosStrategy : IResultHttpStrategy
    {
        public void ProcesarRespuesta(RestResponse respuesta, ListView listView)
        {
            if (respuesta.IsSuccessStatusCode)
            {
                listView.Items.Add(new ListViewItem(new[] { "Eliminar emision", $"Exito, inserciones total:{respuesta.Content.ToString()}" }));
            }
            else
            {
                var res = new ErrorResponse
                {
                    StatusCode = (int)respuesta.StatusCode,
                    Message = respuesta.ErrorMessage ?? respuesta.StatusDescription
                };
                listView.Items.Add(new ListViewItem(new[] { "Eliminar emison", $"Error:{res.StatusCode + res.Message}" }));
            }
        }
    }
}
