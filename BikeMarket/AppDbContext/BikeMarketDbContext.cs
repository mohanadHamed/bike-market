using BikeMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeMarket.AppDbContext
{
    public class BikeMarketDbContext(DbContextOptions<BikeMarketDbContext> options) : DbContext(options)
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }


}
