using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        // Entidades
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor {get; set;}
        public DbSet<VendasRecord> VendasRecord {get; set;}
    }
}
