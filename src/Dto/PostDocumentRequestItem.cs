namespace BlInfoApiWrapper.Dto
{
    public class PostDocumentRequestItem
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public PostDocumentRequestItem()
        {
            Name = string.Empty;
        }
    }
}