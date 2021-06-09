using NUnit.Framework;
using Flurl.Http;
using HomeWork8.Framework.Models;
using System.Text.Json;
using HomeWork8.Framework;


namespace HomeWork8.Tests
{
    [TestFixture]
    public class PostTest
    {
        [Test]
        public void CheckPostTest()
        {
      

            PostPutModel postModel1 = new()
            {
                UserId = "2",
                Title = "Some example for Post Test",
                Body = "Here should be some body",
            };

            var response = Settings.GetPostUrl().PostJsonAsync(postModel1).Result;
            
            var responseBody = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            var json = JsonSerializer.Serialize<PostPutModel>(postModel1);

            PostPutModel postTest = JsonSerializer.Deserialize<PostPutModel>(responseBody);

            var djson = JsonSerializer.Serialize<PostPutModel>(postTest);

            Assert.AreEqual(201, response.StatusCode);
            Assert.AreEqual(json, djson);

        }
    }
}
