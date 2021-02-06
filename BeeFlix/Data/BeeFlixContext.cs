using BeeFlix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeFlix.Data
{
    public class BeeFlixContext : DbContext
    {
        public BeeFlixContext(DbContextOptions<BeeFlixContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Genre)
                .WithMany(g => g.Movies)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Episode>()
                .HasOne(e => e.Movie)
                .WithMany(m => m.Episodes)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Episode> Episode { get; set; }
    }
}
