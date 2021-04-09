using System;
using System.Collections.Generic;
using System.Text;
using Aplicacion;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetallePago>().HasKey(ci => new {ci.ConceptoId, ci.PagoId});
        }

        public DbSet<AnioLectivo> AnioLectivo { get; set; }
        public DbSet<Concepto> Concepto { get; set; }
        public DbSet<DetallePago> DetallePago { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Pago> Pago { get; set; }

    }
}
