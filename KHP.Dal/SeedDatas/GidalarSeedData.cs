using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KHP.Dal.SeedDatas
{
    public class GidalarSeedData : IEntityTypeConfiguration<Gida>
    {
        public void Configure(EntityTypeBuilder<Gida> builder)
        {
            string resimKlasoru = "Resimler";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            builder.HasData(
                               new Gida
                               {
                                   ID = 1,
                                   Ad = "Salata",
                                   Kalori = 152,
                                   Porsiyon = 1,
                                   GidaTuru = "Yiyecek",
                                   Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "salata.jpeg"))
                               },
                           new Gida
                           {
                               ID = 2,
                               Ad = "Ispanaklı Pizza",
                               Kalori = 234,
                               Porsiyon = 1,
                               GidaTuru = "Pizza",
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "ispanakli.jpeg"))

                           },
                           new Gida
                           {
                               ID = 3,
                               Ad = "Karidesli Pizza",
                               Kalori = 209,
                               Porsiyon = 1,
                               GidaTuru = "Pizza",
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "karidesli.jpeg "))
                           },
                           new Gida
                           {
                               ID = 4,
                               Ad = "Mantarlı Pizza",
                               Kalori = 212,
                               GidaTuru = "Pizza",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "mantarli.jpeg "))
                           },
                           new Gida
                           {
                               ID = 5,
                               Ad = "Margarita Pizza",
                               Kalori = 275,
                               GidaTuru = "Pizza",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "margarita.jpeg "))
                           },
                           new Gida
                           {
                               ID = 6,
                               Ad = "Armut",
                               Kalori = 57,
                               GidaTuru = "Meyve",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "armut.jpeg "))
                           },
                           new Gida
                           {
                               ID = 7,
                               Ad = "Avokado",
                               Kalori = 160,
                               GidaTuru = "Meyve",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "avokado.jpeg"))
                           },
                           new Gida
                           {
                               ID = 8,
                               Ad = "Hurma",
                               Kalori = 282,
                               GidaTuru = "Meyve",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "hurma.jpeg"))
                           },
                           new Gida
                           {
                               ID = 9,
                               Ad = "Muz",
                               Kalori = 122,
                               GidaTuru = "Meyve",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "muz.jpeg"))
                           },
                           new Gida
                           {
                               ID = 10,
                               Ad = "Kahve",
                               Kalori = 5,
                               GidaTuru = "Icecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "kahve.jpeg"))
                           },
                           new Gida
                           {
                               ID = 11,
                               Ad = "Bonfile",
                               Kalori = 138,
                               GidaTuru = "Et ve Et Urunleri",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "bonfile.jpeg"))
                           },
                           new Gida
                           {
                               ID = 12,
                               Ad = "Hindi",
                               Kalori = 189,
                               GidaTuru = "Et ve Et Urunleri",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "hindi.jpeg"))
                           },
                           new Gida
                           {
                               ID = 13,
                               Ad = "Tavuk Butu",
                               Kalori = 174,
                               GidaTuru = "Et ve Et Urunleri",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "tavukbutu.jpeg"))

                           },
                           new Gida
                           {
                               ID = 14,
                               Ad = "Tavuk Göğsü",
                               Kalori = 172,
                               GidaTuru = "Et ve Et Urunleri",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "tavukgogsu.jpeg"))
                           },
                           new Gida
                           {
                               ID = 15,
                               Ad = "Ananas Suyu",
                               Kalori = 53,
                               GidaTuru = "İcecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "ananassuyu.jpeg"))
                           },
                           new Gida
                           {
                               ID = 16,
                               Ad = "Capri-Sun",
                               Kalori = 41,
                               GidaTuru = "İcecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "caprisun.jpeg"))
                           },
                           new Gida
                           {
                               ID = 17,
                               Ad = "Havuç Suyu",
                               Kalori = 40,
                               GidaTuru = "İcecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "havucsuyu.jpeg"))
                           },
                           new Gida
                           {
                               ID = 18,
                               Ad = "Limonata",
                               Kalori = 50,
                               GidaTuru = "İcecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "limonata.jpeg"))
                           },
                           new Gida
                           {
                               ID = 19,
                               Ad = "Bamya",
                               Kalori = 33,
                               GidaTuru = "Baklagiller",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "bamya.jpeg"))
                           },
                           new Gida
                           {
                               ID = 20,
                               Ad = "Bezelye",
                               Kalori = 42,
                               GidaTuru = "Baklagiller",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "bezelye.jpeg"))
                           },
                           new Gida
                           {
                               ID = 21,
                               Ad = "Mercimek",
                               Kalori = 353,
                               GidaTuru = "Baklagiller",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "mercimek.jpeg"))
                           },
                           new Gida
                           {
                               ID = 22,
                               Ad = "Nohut",
                               Kalori = 364,
                               GidaTuru = "Baklagiller",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "nohut.jpeg"))

                           },
                           new Gida
                           {
                               ID = 23,
                               Ad = "Pilav",
                               Kalori = 130,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                               Resim = File.ReadAllBytes(Path.Combine(baseDirectory, resimKlasoru, "pilav.jpeg"))

                           });
        }
    }
}
