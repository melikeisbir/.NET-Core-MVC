using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.MVC.Data.Migrations
{
    public partial class mik3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolumlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Derslers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencilers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    BolumlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencilers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencilers_Bolumlers_BolumlerId",
                        column: x => x.BolumlerId,
                        principalTable: "Bolumlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VizeNotu = table.Column<int>(type: "int", nullable: false),
                    FinalNotu = table.Column<int>(type: "int", nullable: false),
                    Ortalama = table.Column<double>(type: "float", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    OgrencilerId = table.Column<int>(type: "int", nullable: false),
                    DerslerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notlars_Derslers_DerslerId",
                        column: x => x.DerslerId,
                        principalTable: "Derslers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlars_Ogrencilers_OgrencilerId",
                        column: x => x.OgrencilerId,
                        principalTable: "Ogrencilers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_DerslerId",
                table: "Notlars",
                column: "DerslerId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlars_OgrencilerId",
                table: "Notlars",
                column: "OgrencilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencilers_BolumlerId",
                table: "Ogrencilers",
                column: "BolumlerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notlars");

            migrationBuilder.DropTable(
                name: "Derslers");

            migrationBuilder.DropTable(
                name: "Ogrencilers");

            migrationBuilder.DropTable(
                name: "Bolumlers");
        }
    }
}
