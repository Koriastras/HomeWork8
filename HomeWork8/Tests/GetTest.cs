using Flurl.Http;
using NUnit.Framework;
using HomeWork8.Framework.Models;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using HomeWork8.Framework;
using FluentAssertions;
using Flurl.Http.Testing;

namespace HomeWork8.Tests
{
    [TestFixture]
    public class GetTest
    {
        [Test]
        public void CheckGetTest()
        {
            GetModel getModel = new()
            {
                UserId = "1",
                Id = "1",
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
            };



            var response = Settings.GetUrl().GetAsync().Result;
            var responseBody = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            var json = JsonSerializer.Serialize<GetModel>(getModel);

            GetModel res = JsonConvert.DeserializeObject<GetModel>(responseBody);
            var djson = JsonConvert.SerializeObject(res);


            Assert.AreEqual(json, djson);
           Assert.AreEqual(200, response.StatusCode);
            
        }
    }
}
