using System.Data.Entity;

namespace EOEOSystem.Model
{
    class UnitDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
