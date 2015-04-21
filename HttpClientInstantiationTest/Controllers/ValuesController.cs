using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HttpClientInstantiationTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<string> GetAsync()
        {
            if (Request.Headers.Authorization != null)
                return Request.Headers.Authorization.ToString();
            else
                return "NoAuthorizationHeaderFound";
        }

    }
}
