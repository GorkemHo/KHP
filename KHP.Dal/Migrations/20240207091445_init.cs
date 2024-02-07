﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KHP.Dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ogunler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gidalar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Porsiyon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GidaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gidalar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Gidalar_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Gidalar",
                columns: new[] { "ID", "Ad", "GidaTuru", "Kalori", "OgunID", "Porsiyon" },
<<<<<<<< HEAD:KHP.Dal/Migrations/20240207091445_init.cs
                values: new object[] { 1, "Salata", "Icecek", 152m, null, 1m });
========
                values: new object[] { 1, "Salata", "Yiyecek", 152m, null, 1m });
>>>>>>>> origin/furkan:KHP.Dal/Migrations/20240207094927_init.cs

            migrationBuilder.InsertData(
                table: "Gidalar",
                columns: new[] { "ID", "Ad", "GidaTuru", "Kalori", "OgunID", "Porsiyon" },
                values: new object[] { 2, "Kek", "Yiyecek", 357m, null, 1m });

            migrationBuilder.InsertData(
                table: "Gidalar",
                columns: new[] { "ID", "Ad", "GidaTuru", "Kalori", "OgunID", "Porsiyon" },
                values: new object[] { 3, "Tost", "Yiyecek", 289m, null, 1m });

            migrationBuilder.CreateIndex(
                name: "IX_Gidalar_OgunID",
                table: "Gidalar",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciID",
                table: "Ogunler",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gidalar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}