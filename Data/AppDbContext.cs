using An_e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace An_e_commerce_app.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        
        {
            
        }
        protected override object OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<trackcategory_tracks>().HasKey(aa=>new
            
                           { aa.trackcategoryid,
                aa.Addtrackid,
            });
            modelBuilder.Entity<artist_Track>().HasOne(a => a.track).WithMany(aa => aa.trackcategoryAddtracks).HasForeignkey(artist => a.trackcategoryid);
            modelBuilder.Entity<artist_Track>()
                        .HasOne(a =>
                        {
                            return a.track;
                        })
                        .WithMany(aa => aa.trackcategoryAddtracks)
                        .HasForeignkey(artist => a.Addtrackid);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<artist> artists { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<trackcategory> trackcategory { get; set; }
        public DbSet<Addtrack> Addtrack { get; set; }
    }
 
}
