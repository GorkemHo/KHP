using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KHP.Dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Resim = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gidalar", x => x.ID);
                });

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
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciGidalar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    GidaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GidaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Porsiyon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OgunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGidalar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciGidalar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gidalar",
                columns: new[] { "ID", "Ad", "GidaTuru", "Kalori", "Porsiyon", "Resim" },
                values: new object[,]
                {
                    { 1, "Salata", "Yiyecek", 152m, 1m, null },
                    { 2, "Kek", "Yiyecek", 357m, 1m, null },
                    { 3, "Tost", "Yiyecek", 289m, 1m, null },
                    { 4, "Pizza", "Yiyecek", 30m, 1m, null },
                    { 5, "Makarna", "Meyve", 30m, 1m, null },
                    { 6, "Burger", "Yiyecek", 300m, 1m, null },
                    { 7, "Köfte", "Yiyecek", 320m, 1m, null },
                    { 8, "Patates", "Yiyecek", 77m, 1m, null },
                    { 9, "Soğan", "Yiyecek", 40m, 1m, null },
                    { 10, "Kahve", "Icecek", 211m, 1m, null },
                    { 11, "Çay", "Icecek", 110m, 1m, null },
                    { 12, "Pankek", "Yiyecek", 352m, 1m, null },
                    { 13, "Meyve Suyu", "Icecek", 190m, 1m, null },
                    { 14, "Brownie", "Yiyecek", 250m, 1m, null },
                    { 15, "Yoğurt", "Yiyecek", 59m, 1m, null },
                    { 16, "Havuç", "Yiyecek", 95m, 1m, null },
                    { 17, "Turp", "Yiyecek", 52m, 1m, null },
                    { 18, "Kola", "İcecek", 178m, 1m, null },
                    { 19, "Peynir", "Yiyecek", 328m, 1m, null },
                    { 20, "Domates", "Yiyecek", 85m, 1m, null },
                    { 21, "Zeytin", "Yiyecek", 105m, 1m, null },
                    { 22, "Dondurma", "Yiyecek", 105m, 1m, null },
                    { 23, "ET", "Yiyecek", 350m, 1m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciGidalar_KullaniciId",
                table: "KullaniciGidalar",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gidalar");

            migrationBuilder.DropTable(
                name: "KullaniciGidalar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
