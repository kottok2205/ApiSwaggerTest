using System.Text;

namespace ApiSwaggerTest
{
    public class Precondition : BaseTest
    {
        public async Task<HttpResponseMessage> PreconditionTest(string category)
        {
            var requestContent = new StringContent(RequestJson, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(baseUrl + $"{category}", requestContent);
            return response;
        }
    }
}
