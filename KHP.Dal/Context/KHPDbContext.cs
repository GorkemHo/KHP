using KHP.Dal.EntityTypeConfigurations;
using KHP.Dal.SeedDatas;
using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Dal.Context
{
    public class KHPDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Gida> Gidalar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-NNPAIJ5; Database=KHP; Uid=sa; Pwd=789;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-JI3UVS4;Database=KHP;Uid=sa;Pwd=123;");
            
            optionsBuilder.UseSqlServer(@"Server=G™RKEMH; Database=KHPDb; Uid=sa; Pwd=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GidaTypeConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OgunTypeConfiguration());

            modelBuilder.Entity<Gida>()
                .Property(g => g.GidaTuru)
                .HasConversion<string>();

            modelBuilder.ApplyConfiguration(new GidalarSeedData());

            base.OnModelCreating(modelBuilder);
        }
    }
}
