using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        internal async Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
