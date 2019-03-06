using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToyoBrowser.Models
{
    public class ToyoContext: DbContext
    {
        public ToyoContext(DbContextOptions<ToyoContext> options): base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public DbSet<TrimsLevel> TrimsLevels { get; set; }
        public DbSet<TrimsLevel_Features> TrimsLevel_Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleClass> VehicleClass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrimsLevel_Features>()
                .HasKey(s => new {s.FeaturesId, s.TrimsLevelId});

            modelBuilder.Entity<TrimsLevel>()
                .HasOne(t => t.Motor)
                .WithMany(m => m.TrimsLevels)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
