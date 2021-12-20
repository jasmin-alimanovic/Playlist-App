using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist.Migrations
{
    public partial class Initialstate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pjesma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazivIzvodjaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocjena = table.Column<byte>(type: "tinyint", nullable: false),
                    JeLiFavorit = table.Column<bool>(type: "bit", nullable: false),
                    DatumUnosa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumEditovanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pjesma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pjesma_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorija",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 2, "Pop" },
                    { 3, "Rock" },
                    { 4, "Narodna" },
                    { 5, "Jazz" },
                    { 6, "Heavy metal" },
                    { 7, "Klasična" },
                    { 8, "Turbofolk" },
                    { 9, "Rep" },
                    { 10, "Reggae" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pjesma_KategorijaId",
                table: "Pjesma",
                column: "KategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pjesma");

            migrationBuilder.DropTable(
                name: "Kategorija");
        }
    }
}
