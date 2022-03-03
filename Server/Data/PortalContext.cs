using Microsoft.EntityFrameworkCore;
using Portal.Shared.Models;

namespace Portal.Server.Data;

public class PortalContext : DbContext
{
    public DbSet<Location> Locations => Set<Location>();
    
    public PortalContext (DbContextOptions<PortalContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>()
            .HasIndex(l => l.Slug)
            .IsUnique();
    }
}