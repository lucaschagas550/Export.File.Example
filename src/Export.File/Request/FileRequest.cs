namespace Export.File.Request
{
    public class FileRequest
    {
        public string Content { get; set; }
        public string FileType { get; set; }

        public FileRequest() { }

        public FileRequest(string content, string fileType)
        {
            Content = content;
            FileType = fileType;
        }
    }
}
