using RestSharp;
using System.Threading.Tasks;

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
            request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse> DeleteAsync(string url)
        {
            var request = new RestRequest(url, Method.Delete);
            return await client.ExecuteAsync(request);
        }
    }
}
