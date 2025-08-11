using Microsoft.EntityFrameworkCore;
using Universidad;


namespace Contexto
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SMD1HLC\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=true;TrustServerCertificate=True");
        }
        public UniversidadContext()
        {
            this.Database.EnsureCreated();
            
        }


    }
}
