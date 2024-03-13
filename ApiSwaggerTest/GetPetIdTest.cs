using NUnit.Framework.Legacy;
using System.Text;
using System.Text.RegularExpressions;

namespace ApiSwaggerTest
{
    public class GetPetIdTest : BaseTest
    {
        [TestCase("pet")]
        [Test]
        public async Task PostAPITest(string category)
        {
            var requestJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\request.json");
            var responseJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\response.json");
            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(baseUrl + $"{category}", requestContent);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);

            var responseContent = await response.Content.ReadAsStringAsync();
            var normalizedExpected = Regex.Replace(responseJson, @"\s+", "");
            var normalizedActual = Regex.Replace(responseContent, @"\s+", "");

            ClassicAssert.AreEqual(normalizedExpected, normalizedActual);
        }

        [TestCase("pet", "123456789")]
        [Test]
        public async Task GetAPITest(string category, string idCategory)
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl + $"{category}/{idCategory}");
            var responseJson = File.ReadAllText(@"d:\VSProject\APISwaggerTest\ApiSwaggerTest\response.json");

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);

            string responseData = await response.Content.ReadAsStringAsync();

            var normalizedExpected = Regex.Replace(responseJson, @"\s+", "");
            var normalizedActual = Regex.Replace(responseData, @"\s+", "");

            ClassicAssert.AreEqual(normalizedExpected, normalizedActual);
        }
    }
}