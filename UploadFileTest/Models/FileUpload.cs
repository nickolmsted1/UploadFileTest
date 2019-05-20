using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UploadFileTest.Models
{
    public class Image
    {
        public IFormFile FileToUpload { get; set; }
        public string FileName { get; set; }

    }
}
