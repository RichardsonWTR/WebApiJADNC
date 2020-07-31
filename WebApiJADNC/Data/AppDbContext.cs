using Microsoft.EntityFrameworkCore;
using WebApiJADNC.Models;

namespace WebApiJADNC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
        }
    }
}