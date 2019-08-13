using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess
{
    public  class IMDBDbContext : DbContext
    {
        public IMDBDbContext(DbContextOptions<IMDBDbContext> dbContext) : base (dbContext)
        {

        }
        public DbSet<Actor> actors { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<Movies> movies { get; set; }

    }
}