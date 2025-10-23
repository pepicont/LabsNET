using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true;TrustServerCertificate=True")
                .LogTo(Console.WriteLine, LogLevel.Information); // Configura el logging para ver las consultas SQL
        }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasData(
                new Alumno { Id = -1, Nombre = "Juan", Apellido = "Pérez", Legajo = "12345", Direccion = "Calle Falsa 123" },
            new Alumno { Id = -2, Nombre = "María", Apellido = "Gómez", Legajo = "67890", Direccion = "Avenida Siempre Viva 742" },
            new Alumno { Id = -3, Nombre = "Luis", Apellido = "Rodríguez", Legajo = "54321", Direccion = "Boulevard de los Sueños Rotos 456" },
            new Alumno { Id = -4, Nombre = "Ana", Apellido = "López", Legajo = "98765", Direccion = "Calle del Sol 789" });


        }
    }
}


