using Microsoft.AspNetCore.Mvc;

namespace Export.File.Response
{
    public class FileResponse
    {
        public byte[] FileContents { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public bool IsEnableRangeProcessing { get; set; }

        public FileResponse() { }

        public FileResponse(byte[] fileContents, string name, string type, string contentType, bool isEnableRangeProcessing = false)
        {
            FileContents = fileContents;
            Name = name;
            ContentType = contentType;
            IsEnableRangeProcessing = isEnableRangeProcessing;
            Type = type;
        }
    }
}
