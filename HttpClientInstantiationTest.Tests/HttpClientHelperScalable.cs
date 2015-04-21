using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientInstantiationTest.Tests
{
    public class HttpClientHelperScalable
    {

        private static readonly HttpClient httpClient;

        public static HttpClientHelperScalable ()
        {
            httpClient = new HttpClient();
        }
	
        public async Task<HttpResponseMessage> CallHttpClientGetAsync(string requestUri, string authHeader)
        {

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authHeader);
                var response = await httpClient.GetAsync(requestUri);
                return response;
        }
    }
}
