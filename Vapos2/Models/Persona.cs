using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vapos2.Models
{
    public class Persona
    {
        [Key]
        public String nombreApe { get; set; }
        public int telefono { get; set; }
    }
}
