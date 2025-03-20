using App_VerFormsAPI.ResponseHttp;
using RestSharp;
using System;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy.Concretas
{
    public class AgregarRegistrosListadoRequerimientosStrategy : IResultHttpStrategy
    {
        public void ProcesarRespuesta(RestResponse respuesta, ListView listView)
        {
            if (respuesta.IsSuccessStatusCode)
            {
                listView.Items.Add(new ListViewItem(new[] { "Agrear Listado Requerimientos", $"Exito, inserciones total:{respuesta.Content.ToString()}" }));
            }
            else
            {
                var res = new ErrorResponse
                {
                    StatusCode = (int)respuesta.StatusCode,
                    Message = respuesta.ErrorMessage ?? respuesta.StatusDescription
                };
                listView.Items.Add(new ListViewItem(new[] { "Agrear Listado Requerimientos", $"Error:{res.Message}" }));
            }
        }
    }
}
