using KHP.Bll.IServices;
using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Dal.SeedDatas
{
    public class KullaniciSeedData : IEntityTypeConfiguration<Kullanici>
    {
        IKullaniciService _service;

        public KullaniciSeedData(IKullaniciService service)
        {
            _service = service;
        }
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(
                new Kullanici
                {
                    ID = 1,
                    Ad = "Görkem",
                    Soyad = "Hoşca",
                    Eposta = "gorkemhosca@gmail.",
                    Sifre = _service.sha256("12345678"),
                    Cinsiyet = true,
                    DogumTarihi = new DateTime(1995, 1, 1)

                });

        }
    }
}
