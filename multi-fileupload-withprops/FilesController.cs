using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MultiFileuploadWithProps
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        [HttpPost("{id:int}")]
        public IActionResult FileUpload([FromRoute] int id, [FromForm] FileUploadDto uploadDto)
        {
            return new ObjectResult(uploadDto);
        }
    }
}