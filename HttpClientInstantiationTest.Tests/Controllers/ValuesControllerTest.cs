using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HttpClientInstantiationTest;
using HttpClientInstantiationTest.Controllers;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace HttpClientInstantiationTest.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        private string endpoint = "https://ecuxdut.dns.microsoft.com/HttpClientTest/api/values";

        [TestMethod]
        public async Task GetAsyncTestNotScalable()
        {
            var sut = new HttpClientHelper();
            var authHeader = Guid.NewGuid().ToString();
            var result = await sut.CallHttpClientGetAsync(endpoint, authHeader);
            var content = await result.Content.ReadAsStringAsync();
            Assert.AreEqual(authHeader,content.Replace("\"", ""));
        }

        [TestMethod]
        public async Task GetAsyncTestScalable()
        {
            var sut = new HttpClientHelperScalable();
            var authHeader = Guid.NewGuid().ToString();
            var result = await sut.CallHttpClientGetAsync(endpoint, authHeader);
            var content = await result.Content.ReadAsStringAsync();
            Assert.AreEqual(authHeader, content.Replace("\"", ""));
        }

    }
}
