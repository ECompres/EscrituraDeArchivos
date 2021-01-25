using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apistreamwritter.Models;
using System.IO;

namespace apistreamwritter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchivosController : ControllerBase
    {
        [HttpPost]
        public IActionResult CrearArchivo([FromBody] Archivo archivo)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                StreamWriter objstreamwriter = new StreamWriter(stream);
                objstreamwriter.Write(archivo.FileName);
                objstreamwriter.Flush();
                objstreamwriter.Close();
                return File(stream.ToArray(), "text/plain", archivo.FileName);
            }
        }
    }
}
