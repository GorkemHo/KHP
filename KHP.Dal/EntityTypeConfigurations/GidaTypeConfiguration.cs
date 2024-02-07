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
    public class GidaTypeConfiguration : IEntityTypeConfiguration<Gida>
    {
        public void Configure(EntityTypeBuilder<Gida> builder)
        {
            builder.HasOne(g => g.Ogun)
                    .WithMany(o => o.Yemekler)
                    .HasForeignKey(g => g.OgunID);

            builder.Property(g => g.OgunID).IsRequired(false);
            builder.Property(g => g.Ad).IsRequired();
            builder.Property(g => g.Kalori).IsRequired();
            builder.Property(g => g.Porsiyon).IsRequired();
            builder.Property(g => g.GidaTuru).IsRequired();

        }
    }
}
