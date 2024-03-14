using BaseClientService;

namespace ApiSwaggerTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://petstore.swagger.io/v2/";
        protected string requestJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\request.json");
        protected string responseJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\response.json");

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
