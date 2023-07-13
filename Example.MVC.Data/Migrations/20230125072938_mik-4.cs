using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.MVC.Data.Migrations
{
    public partial class mik4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrencilers_Bolumlers_BolumlerId",
                table: "Ogrencilers");

            migrationBuilder.DropIndex(
                name: "IX_Ogrencilers_BolumlerId",
                table: "Ogrencilers");

            migrationBuilder.DropColumn(
                name: "BolumlerId",
                table: "Ogrencilers");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencilers_BolumId",
                table: "Ogrencilers",
                column: "BolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrencilers_Bolumlers_BolumId",
                table: "Ogrencilers",
                column: "BolumId",
                principalTable: "Bolumlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrencilers_Bolumlers_BolumId",
                table: "Ogrencilers");

            migrationBuilder.DropIndex(
                name: "IX_Ogrencilers_BolumId",
                table: "Ogrencilers");

            migrationBuilder.AddColumn<int>(
                name: "BolumlerId",
                table: "Ogrencilers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencilers_BolumlerId",
                table: "Ogrencilers",
                column: "BolumlerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrencilers_Bolumlers_BolumlerId",
                table: "Ogrencilers",
                column: "BolumlerId",
                principalTable: "Bolumlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
