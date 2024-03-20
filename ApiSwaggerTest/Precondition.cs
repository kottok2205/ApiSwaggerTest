using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSwaggerTest
{
    public class Precondition : BaseTest
    {
        public async Task<HttpResponseMessage> PreconditionTest(string category)
        {
            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(baseUrl + $"{category}", requestContent);
            return response;
        }
    }
}
