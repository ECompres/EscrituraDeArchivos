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
            string ruta = "C:\\Prueba\\Files\\";
            string file = ruta + archivo.FileName + ".txt";
            if (Directory.Exists(ruta))
            {   
                using (StreamWriter SW = new StreamWriter(file))
                {
                    SW.WriteLine(archivo.FileText);
                };

            }
            else
            {
                Directory.CreateDirectory(ruta);
                using (StreamWriter SW = new StreamWriter(file))
                {
                    SW.WriteLine(archivo.FileText);
                };
            }
            return Ok("Archivo creado en " + file);
        }
    }
}
