using Microsoft.EntityFrameworkCore;
using SeguimientoNutricional.App.Dominio;

namespace SeguimientoNutricional.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Coach> Coach { get; set; }

        public DbSet<HistorialRecomendacion> HistorialRecomendacion { get; set; }

        public DbSet<HistorialValoracion> HistorialValoracion { get; set; }

        public DbSet<Nutricionista> Nutricionista { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Recomendacion> Recomendacion { get; set; }

        public DbSet<Valoracion> Valoracion { get; set; }

        //public DbSet<Genero> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SeguimientoNutricional.Data");
            }
        }
    }
}