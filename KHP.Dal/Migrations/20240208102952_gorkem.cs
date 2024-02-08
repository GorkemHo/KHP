using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KHP.Dal.Migrations
{
    public partial class gorkem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gidalar_Ogunler_OgunID",
                table: "Gidalar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropIndex(
                name: "IX_Gidalar_OgunID",
                table: "Gidalar");

            migrationBuilder.DropColumn(
                name: "OgunID",
                table: "Kullanicilar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgunID",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Gidalar_OgunID",
                table: "Gidalar",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciID",
                table: "Ogunler",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gidalar_Ogunler_OgunID",
                table: "Gidalar",
                column: "OgunID",
                principalTable: "Ogunler",
                principalColumn: "ID");
        }
    }
}
