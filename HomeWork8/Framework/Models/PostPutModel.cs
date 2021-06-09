


using Newtonsoft.Json;

namespace HomeWork8.Framework.Models
{
    public class PostPutModel
    {
        [JsonProperty("UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("Body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

    }
}
