using System;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;


namespace signalR_project.Controllers
{
    [Route("api/upload")]
    public class uploadController : Controller
    {
        [HttpPost]
        [RequestSizeLimit(53687091200)]
        [Route("Upload")]
        public string upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                string folderName = "UploadContent";
                string newPath = Path.Combine("E:\\", folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length > 0)
                {
                    string fileName = "new2";
                    string fullPath = Path.Combine(newPath, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                return ("File Uploaded Sucessfully");
            }
            catch(Exception e)
            {
                throw (e.InnerException);
            }
        }
    }
}
