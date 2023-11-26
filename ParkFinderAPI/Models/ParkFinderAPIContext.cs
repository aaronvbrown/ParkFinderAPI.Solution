using Microsoft.EntityFrameworkCore;

namespace ParkFinderAPI.Models
{
  public class ParkFinderAPIContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParkFinderAPIContext(DbContextOptions<ParkFinderAPIContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Yellowstone", State = "Montana", Type = "National Park"},
          new Park { ParkId = 2, Name = "Crater Lake", State = "Oregon", Type = "National Park"},
          new Park { ParkId = 3, Name = "Cape Lookout", State = "Oregon", Type = "State Park"},
          new Park { ParkId = 4, Name = "Gifford Pinchot", State = "Washington", Type = "National Forest"}
        );
    }
  }
}