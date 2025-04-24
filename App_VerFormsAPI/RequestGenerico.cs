using RestSharp;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace App_VerFormsAPI
{
    public class RequestGenerico
    {
        private static readonly RestClient client = new RestClient();

        public static async Task<RestResponse> GetAsync(string url)
        {
            var request = new RestRequest(url, Method.Get);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse> PostAsync(string url, object body)
        {
            var request = new RestRequest(url, Method.Post);
            request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse> PutAsync(string url, object body = null)
        {
            var request = new RestRequest(url, Method.Put);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse> PutBodyAsync(string url, object body)
        {
            var resquest = new RestRequest(url, method: Method.Put);
            resquest.AddJsonBody(body);
            return await client.ExecuteAsync(resquest);
        }

        public static async Task<RestResponse> DeleteAsync(string url, object body)
        {
            var request = new RestRequest(url, Method.Delete);
            request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }
    }
}
