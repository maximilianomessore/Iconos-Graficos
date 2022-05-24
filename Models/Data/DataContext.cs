using Microsoft.EntityFrameworkCore;

namespace Iconos_Graficos.Models.Data
{
        public class DataContext : DbContext
            {
                public DataContext(DbContextOptions<DataContext> options) : base(options) { }

                public DbSet<City> cities { get; set; }
                public DbSet<Continent> continents { get; set; }
                public DbSet<GraphicIcon> GraphicIcons { get; set; }
            }
    
}
