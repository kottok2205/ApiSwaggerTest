using BaseClientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSwaggerTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://petstore.swagger.io/v2/";

        [SetUp]
        public void Setup()
        {
            BaseHttpClient.GetInstance();
        }

        [TearDown]
        public void TearDown()
        {
            BaseHttpClient.QuitInstance();
        }
    }
}
