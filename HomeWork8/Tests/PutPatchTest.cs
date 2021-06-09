using NUnit.Framework;
using Flurl.Http;
using HomeWork8.Framework.Models;
using System.Text.Json;
using HomeWork8.Framework;


namespace HomeWork8.Tests
{
    [TestFixture]
    public class PutPatchTest
    {
        [Test]
        public void CheckPutTest()
        {
            PostPutModel putModel1 = new()
            {
                UserId = "1",
                Title = "Some example for Put Test",
                Body = "Here should be some body for post test"
            };

            var response = Settings.GetUrl().PutJsonAsync(putModel1).Result;
            var responsebody = response.ResponseMessage.Content.ReadAsStringAsync().Result;

            var json = JsonSerializer.Serialize<PostPutModel>(putModel1);

            PostPutModel putTest = JsonSerializer.Deserialize<PostPutModel>(responsebody);

            var djson = JsonSerializer.Serialize<PostPutModel>(putTest);

            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(json, djson);
        }

        [Test]
        public void CheckPatchTest()
        {
            PostPutModel patchModel1 = new()
            {

                Title = "Some example for Patch Test",

            };


            var response = Settings.GetUrl().PatchJsonAsync(patchModel1).Result;
            var responsebody = response.ResponseMessage.Content.ReadAsStringAsync().Result;



            var json = JsonSerializer.Serialize<PostPutModel>(patchModel1);

            PostPutModel patchTest = JsonSerializer.Deserialize<PostPutModel>(responsebody);

            var djson = JsonSerializer.Serialize<PostPutModel>(patchTest);

            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(json, djson);
        }

    }
}
