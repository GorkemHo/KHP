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
                           });
            //               new Gida
            //               {
            //                   ID = 4,
            //                   Ad = "Pizza",
            //                   Kalori = 30,
            //                   GidaTuru = "Yiyecek",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 5,
            //                   Ad = "Kavun",
            //                   Kalori = 30,
            //                   GidaTuru = "Meyve",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 6,
            //                   Ad = "Domates",
            //                   Kalori = 18,
            //                   GidaTuru = "Sebze",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 7,
            //                   Ad = "Salatalık",
            //                   Kalori = 15,
            //                   GidaTuru = "Sebze",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 8,
            //                   Ad = "Patates",
            //                   Kalori = 77,
            //                   GidaTuru = "Sebze",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 9,
            //                   Ad = "Soğan",
            //                   Kalori = 40,
            //                   GidaTuru = "Sebze",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID = 10,
            //                   Ad = "Havuç",
            //                   Kalori = 41,
            //                   GidaTuru = "Sebze",
            //                   OgunID = 1
            //               },
            //               new Gida
            //               {
            //                   ID =
            //               })
        }
    }
}
