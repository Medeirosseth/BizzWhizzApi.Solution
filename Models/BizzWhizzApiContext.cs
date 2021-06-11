using Microsoft.EntityFrameworkCore;

namespace BizzWhizzApi.Models
{
  public class BizzWhizzApiContext : DbContext
  {
    public BizzWhizzApiContext(DbContextOptions<BizzWhizzApiContext>options)
    : base(options)
    {
    }

    public DbSet<Business> businesses { get; set; }
  }
}