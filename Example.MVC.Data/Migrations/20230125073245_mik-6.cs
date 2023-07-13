using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.MVC.Data.Migrations
{
    public partial class mik6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlars_Derslers_DerslerId",
                table: "Notlars");

            migrationBuilder.DropIndex(
                name: "IX_Notlars_DerslerId",
                table: "Notlars");

            migrationBuilder.DropColumn(
                name: "DerslerId",
                table: "Notlars");

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_DersId",
                table: "Notlars",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlars_Derslers_DersId",
                table: "Notlars",
                column: "DersId",
                principalTable: "Derslers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlars_Derslers_DersId",
                table: "Notlars");

            migrationBuilder.DropIndex(
                name: "IX_Notlars_DersId",
                table: "Notlars");

            migrationBuilder.AddColumn<int>(
                name: "DerslerId",
                table: "Notlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_DerslerId",
                table: "Notlars",
                column: "DerslerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlars_Derslers_DerslerId",
                table: "Notlars",
                column: "DerslerId",
                principalTable: "Derslers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
