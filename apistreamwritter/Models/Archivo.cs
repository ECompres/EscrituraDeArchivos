using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apistreamwritter.Models
{
    public class Archivo
    {
        [Required]
        public string FileName { get; set; }
        [Required]
        public string FileText { get; set; }
    }
}
