using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientInstantiationTest.Tests
{
    public class HttpClientHelper 
    {
        public async Task<HttpResponseMessage> CallHttpClientGetAsync(string requestUri, string authHeader)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authHeader);
                var response = await client.GetAsync(requestUri);
                return response;
            }
        }
    }
}
