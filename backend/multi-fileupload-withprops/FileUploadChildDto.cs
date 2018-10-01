using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MultiFileuploadWithProps
{
    public class FileUploadChildDto
    {
        public IEnumerable<IFormFile> Files { get; set; }

        public string Name { get; set; }
    }
}
