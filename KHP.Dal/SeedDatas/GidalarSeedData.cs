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
            builder.HasData(
                               new Gida
                               {
                                   ID = 1,
                                   Ad = "Salata",
                                   Kalori = 152,
                                   Porsiyon = 1,
                                   GidaTuru = "Yiyecek",
                               },
                           new Gida
                           {
                               ID = 2,
                               Ad = "Kek",
                               Kalori = 357,
                               Porsiyon = 1,
                               GidaTuru = "Yiyecek",
                               
                           },
                           new Gida
                           {
                               ID = 3,
                               Ad = "Tost",
                               Kalori = 289,
                               Porsiyon = 1,
                               GidaTuru = "Yiyecek",
                               
                           },
                           new Gida
                           {
                               ID = 4,
                               Ad = "Pizza",
                               Kalori = 30,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 5,
                               Ad = "Makarna",
                               Kalori = 30,
                               GidaTuru = "Meyve",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 6,
                               Ad = "Burger",
                               Kalori = 300,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 7,
                               Ad = "Köfte",
                               Kalori = 320,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 8,
                               Ad = "Patates",
                               Kalori = 77,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 9,
                               Ad = "Soğan",
                               Kalori = 40,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 10,
                               Ad = "Kahve",
                               Kalori = 211,
                               GidaTuru = "Icecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID =11,
                               Ad = "Çay",
                               Kalori = 110,
                               GidaTuru = "Icecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 12,
                               Ad = "Pankek",
                               Kalori = 352,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 13,
                               Ad = "Meyve Suyu",
                               Kalori = 190,
                               GidaTuru = "Icecek",
                               Porsiyon = 1,
                               
                           },
                           new Gida
                           {
                                 ID = 14,
                                 Ad = "Brownie",
                                 Kalori = 250,
                                 GidaTuru = "Yiyecek",
                                 Porsiyon = 1,
                            },
                           new Gida
                           {
                                 ID = 15,
                                 Ad = "Yoğurt",
                                 Kalori = 59,
                                 GidaTuru = "Yiyecek",
                                 Porsiyon = 1,
                            },
                           new Gida
                           {
                                 ID = 16,
                                 Ad = "Havuç",
                                 Kalori = 95,
                                 GidaTuru = "Yiyecek",
                                 Porsiyon = 1,
                            },
                           new Gida
                           {
                               ID = 17,
                               Ad = "Turp",
                               Kalori = 52,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 18,
                               Ad = "Kola",
                               Kalori = 178,
                               GidaTuru = "İcecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                                 ID = 19,
                                 Ad = "Peynir",
                                 Kalori = 328,
                                 GidaTuru = "Yiyecek",
                                 Porsiyon = 1,
                            },
                           new Gida
                           {
                               ID = 20,
                               Ad = "Domates",
                               Kalori = 85,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new  Gida
                           {
                               ID = 21,
                               Ad = "Zeytin",
                               Kalori = 105,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                           },
                           new Gida
                           {
                               ID = 22,
                               Ad = "Dondurma",
                               Kalori = 105,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                               
                           },
                           new Gida
                           {
                               ID = 23,
                               Ad = "ET",
                               Kalori = 350,
                               GidaTuru = "Yiyecek",
                               Porsiyon = 1,
                               
                           }


                           );
        }
        
        
    }
}
