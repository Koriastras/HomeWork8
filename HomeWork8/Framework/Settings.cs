using System.Text.Json;

namespace HomeWork8.Framework
{
    public class Settings
    {
        public JsonElement response;


        public static string GetUrl()
        {
            var response = "https://jsonplaceholder.typicode.com/posts/1";
            return response;
        }
       
        public static string GetPostUrl()
        {
            var response = "https://jsonplaceholder.typicode.com/posts";
            return response;
        }
    }
}
