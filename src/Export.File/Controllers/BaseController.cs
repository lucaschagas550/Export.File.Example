using Export.File.Response;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Export.File.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected FileContentResult File(FileResponse file)
        {
            Response.Headers.Add("Content-Disposition", file.Name);
            return File(file.FileContents, file.ContentType, $"{file.Name}.{file.Type}", file.IsEnableRangeProcessing);
        }
    }
}
