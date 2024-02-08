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
    public class KullaniciTypeConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            

            builder.Property(k=>k.Ad).IsRequired();
            builder.Property(k=>k.Soyad).IsRequired();
            builder.Property(k=>k.Eposta).IsRequired();
            builder.Property(k=>k.Cinsiyet).IsRequired();
            builder.Property(k=>k.DogumTarihi).IsRequired();
            builder.Property(k=>k.Sifre).IsRequired();
        }
    }
}
