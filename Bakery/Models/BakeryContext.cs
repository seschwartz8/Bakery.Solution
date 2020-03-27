using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Cuisine> Treats { get; set; }
    public virtual DbSet<Restaurant> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public BakeryContext(DbContextOptions options) : base(options) { }
  }
}