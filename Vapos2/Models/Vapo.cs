using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vapos2.Models
{
    public class Vapo
    {
        [Key]
        public String IdVapo { get; set; }

        public int Intecambiador_Izq { get; set; }

        public int Intecambiador_Der { get; set; }
    }
}
