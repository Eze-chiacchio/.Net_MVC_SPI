using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vapos2.Models;

namespace Vapos2.Context
{
    public class RegistrosContext : DbContext
    {
        public
        RegistrosContext(DbContextOptions<RegistrosContext> options) : base(options) { }
        public DbSet<Registro> Registos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Vapo> Vapos { get; set; }
    }
}
