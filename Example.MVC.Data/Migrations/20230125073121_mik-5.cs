using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.MVC.Data.Migrations
{
    public partial class mik5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlars_Ogrencilers_OgrencilerId",
                table: "Notlars");

            migrationBuilder.DropIndex(
                name: "IX_Notlars_OgrencilerId",
                table: "Notlars");

            migrationBuilder.DropColumn(
                name: "OgrencilerId",
                table: "Notlars");

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_OgrenciId",
                table: "Notlars",
                column: "OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlars_Ogrencilers_OgrenciId",
                table: "Notlars",
                column: "OgrenciId",
                principalTable: "Ogrencilers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlars_Ogrencilers_OgrenciId",
                table: "Notlars");

            migrationBuilder.DropIndex(
                name: "IX_Notlars_OgrenciId",
                table: "Notlars");

            migrationBuilder.AddColumn<int>(
                name: "OgrencilerId",
                table: "Notlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_OgrencilerId",
                table: "Notlars",
                column: "OgrencilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlars_Ogrencilers_OgrencilerId",
                table: "Notlars",
                column: "OgrencilerId",
                principalTable: "Ogrencilers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
