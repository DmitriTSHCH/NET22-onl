using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sparja.Models;
using Sparja.Persistance.Configuration;

namespace Sparja.Persistance
{
    public class SparjaDbContext : DbContext
    {
        public SparjaDbContext()
        {
            Database.EnsureCreated();
        }

        public SparjaDbContext(DbContextOptions<SparjaDbContext> options)
            : base(options)
        {
        }
        public DbSet<SparjaEnjoyerForm> SparjaEnjoyerForms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SparjaEnjoyerFormConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
