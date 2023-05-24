using Microsoft.EntityFrameworkCore;
using PersonaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaAPI.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Persona> personas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
