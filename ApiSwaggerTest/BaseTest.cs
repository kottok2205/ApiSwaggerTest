using BaseClientService;

namespace ApiSwaggerTest
{
    public class BaseTest : ResourceManage
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://petstore.swagger.io/v2/";
        protected static string RequestJson => GetResource("request.json");
        protected static string ResponseJson => GetResource("response.json");

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
