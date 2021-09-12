using dijidom_database_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dijidom_database_webapi.Data
{
    public interface IDijiDomDBContext
    {
        DbSet<Ambient> Ambients { get; set; }
        DbSet<Plant> Plants { get; set; }

        DbSet<PlantType> PlantTypes { get; set; }

        DbSet<Soil> Soils { get; set; }

        DbSet<Measurement> Measurements {get; set;}

        int SaveChanges();
    }
}