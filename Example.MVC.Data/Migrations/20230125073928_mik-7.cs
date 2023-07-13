using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.MVC.Data.Migrations
{
    public partial class mik7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DersAdi",
                table: "Derslers",
                type: "varchar(256)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DersAdi",
                table: "Derslers",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(256)");
        }
    }
}
