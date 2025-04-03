using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; } = null!;

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Platform>()
        //         .HasMany(p => p.Commands)
        //         .WithOne(c => c.Platform)
        //         .HasForeignKey(c => c.PlatformId);
        // }
    }
}