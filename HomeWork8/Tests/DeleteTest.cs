using NUnit.Framework;
using Flurl.Http;
using HomeWork8.Framework;

namespace HomeWork8.Tests
{
    [TestFixture]
    public class DeleteTest
    {
       [Test]
        
        public void CheckDeletestatus()
        {
            var response = Settings.GetUrl().DeleteAsync().Result;
                
            Assert.AreEqual(200, response.StatusCode);

        }
    }
}
