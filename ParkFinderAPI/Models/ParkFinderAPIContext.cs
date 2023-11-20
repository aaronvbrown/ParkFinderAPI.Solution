using Microsoft.EntityFrameworkCore;

namespace ParkFinderAPI.Models
{
  public class ParkFinderAPIContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParkFinderAPIContext(DbContextOptions<ParkFinderAPIContext> options) : base(options)
    {
    }
  }
}