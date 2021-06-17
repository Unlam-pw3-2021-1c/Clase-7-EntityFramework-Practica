using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Partials
{
    public class LocalMetadata
    {
        [Required]
        public string Nombre { get; set; }
    }
}
