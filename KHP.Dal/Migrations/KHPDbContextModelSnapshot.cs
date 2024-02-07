﻿// <auto-generated />
using System;
using KHP.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KHP.Dal.Migrations
{
    [DbContext(typeof(KHPDbContext))]
    partial class KHPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KHP.Entities.Gida", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidaTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kalori")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OgunID")
                        .HasColumnType("int");

                    b.Property<decimal>("Porsiyon")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.ToTable("Gidalar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Ad = "Salata",
                            GidaTuru = "Yiyecek",
                            Kalori = 152m,
                            Porsiyon = 1m
                        },
                        new
                        {
                            ID = 2,
                            Ad = "Kek",
                            GidaTuru = "Yiyecek",
                            Kalori = 357m,
                            Porsiyon = 1m
                        },
                        new
                        {
                            ID = 3,
                            Ad = "Tost",
                            GidaTuru = "Yiyecek",
                            Kalori = 289m,
                            Porsiyon = 1m
                        });
                });

            modelBuilder.Entity("KHP.Entities.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("KHP.Entities.KullaniciGida", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("GidaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GidaTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kalori")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("OgunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Porsiyon")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciGidalar");
                });

            modelBuilder.Entity("KHP.Entities.Ogun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("KHP.Entities.Gida", b =>
                {
                    b.HasOne("KHP.Entities.Ogun", "Ogun")
                        .WithMany("Yemekler")
                        .HasForeignKey("OgunID");

                    b.Navigation("Ogun");
                });

            modelBuilder.Entity("KHP.Entities.KullaniciGida", b =>
                {
                    b.HasOne("KHP.Entities.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("KHP.Entities.Ogun", b =>
                {
                    b.HasOne("KHP.Entities.Kullanici", "Kullanici")
                        .WithMany("Ogunler")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("KHP.Entities.Kullanici", b =>
                {
                    b.Navigation("Ogunler");
                });

            modelBuilder.Entity("KHP.Entities.Ogun", b =>
                {
                    b.Navigation("Yemekler");
                });
#pragma warning restore 612, 618
        }
    }
}
