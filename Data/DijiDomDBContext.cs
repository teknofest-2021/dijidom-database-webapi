using dijidom_database_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dijidom_database_webapi.Data
{
    public class DijiDomDBContext : DbContext, IDijiDomDBContext
    {
        public DijiDomDBContext(DbContextOptions<DijiDomDBContext> options) : base(options)
        {

        }

        public DbSet<Ambient> Ambients { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantType> PlantTypes { get; set; }
        public DbSet<Soil> Soils { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DigitalTwin");
        }
    }
}