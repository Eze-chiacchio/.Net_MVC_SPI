using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vapos2.Models
{
    public class Registro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistro{ get; set; }
        
        public DateTime fecha  { get; set; }
        public String IdVapo { get; set; }
        public Vapo vaporizator { get; set; }

       public String nombreApe   { get; set; }

        public Persona responsable { get; set; }

        public Boolean Prueba_Hidráulica { get; set; }
        public Boolean Prueba_Estanqueidad { get; set; }
        public Boolean Prueba_Funcionamiento { get; set; }
        public String  Detalles { get; set; }

    }
}
