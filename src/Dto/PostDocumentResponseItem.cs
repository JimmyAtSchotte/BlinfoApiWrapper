using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostDocumentResponseItem
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        public PostDocumentResponseItem()
        {
        }
    }
}