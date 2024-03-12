using NUnit.Framework.Legacy;
using System.Text;

namespace ApiSwaggerTest
{
    public class GetPetIdTest : BaseTest
    {
        [TestCase("pet")]
        [Test]
        public async Task PostAPITest(string category)
        {
            var requestJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\request.json");
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(baseUrl + $"{category}", content);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);


        }

        [TestCase("pet", "123456789")]
        [Test]
        public async Task GetAPITest(string category, string idCategory)
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl + $"{category}/{idCategory}");

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);

            string responseData = await response.Content.ReadAsStringAsync();

            ClassicAssert.IsNotNull(responseData);
        }
    }
}