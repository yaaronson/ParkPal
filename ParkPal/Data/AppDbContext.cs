using Microsoft.EntityFrameworkCore;
using ParkPal.Models;
using System.Reflection;

namespace ParkPal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Listing> Listings { get; set; }

    }
}
