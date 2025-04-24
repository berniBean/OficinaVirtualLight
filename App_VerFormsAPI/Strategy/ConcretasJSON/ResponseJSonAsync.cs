using App_VerFormsAPI.DTO;
using App_VerFormsAPI.ResponseHttp;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy.ConcretasJSON
{
    public class ResponseJSonAsync : IResultHttpJson<DgEliminarDTO>
    {

        public List<DgEliminarDTO> ResponseAsync(RestResponse respuesta)
        {


            if (respuesta.IsSuccessful)
            {

                var data = JsonConvert.DeserializeObject<List<DgEliminarDTO>>(respuesta.Content);
                return data.ToList();
            }
            else
            {
                
                
                List<DgEliminarDTO> listResponse = new List<DgEliminarDTO>();   
                DgEliminarDTO dg = new DgEliminarDTO();
                
                var res = new ErrorResponse
                {
                    StatusCode = (int)respuesta.StatusCode,
                    Message = respuesta.ErrorMessage ?? respuesta.StatusDescription
                };

                dg.ErrorResponse.Items.Add(new ListViewItem(new[] { "ResponseJsonError", $"Error:{res.Message}" }));

                listResponse.Add(dg);


                return listResponse;
            }



            
                

           
        }
    }
}
