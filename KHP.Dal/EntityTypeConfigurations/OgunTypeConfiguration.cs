using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Dal.EntityTypeConfigurations
{
    public class OgunTypeConfiguration : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.HasOne(o => o.Kullanici)
                    .WithMany(k => k.Ogunler)
                     .HasForeignKey(o => o.KullaniciID);

            builder.HasMany(o => o.Yemekler)
                    .WithOne(g => g.Ogun)
                     .HasForeignKey(g => g.OgunID);
        }
    }
}
