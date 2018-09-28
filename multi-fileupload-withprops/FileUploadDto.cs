using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace MultiFileuploadWithProps
{
    public class FileUploadDto
    {
        public IEnumerable<IFormFile> Files { get; set; }

        public int Age { get; set; }
    }
}