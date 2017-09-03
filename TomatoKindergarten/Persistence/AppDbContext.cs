using Microsoft.EntityFrameworkCore;
using TomatoKindergarten.Core.Models;

namespace TomatoKindergarten.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Photo> Photos { get; set; }
    }
}