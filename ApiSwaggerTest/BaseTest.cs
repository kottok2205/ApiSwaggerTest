using BaseClientService;

namespace ApiSwaggerTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://petstore.swagger.io/v2/";
        protected string requestJson = File.ReadAllText(@"./Data/request.json");
        protected string responseJson = File.ReadAllText(@"./Data/response.json");

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
