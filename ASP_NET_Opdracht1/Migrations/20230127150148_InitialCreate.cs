using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_Opdracht1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regiseur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acteurs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijs = table.Column<float>(type: "real", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdultRating = table.Column<bool>(type: "bit", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Runtime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                }); ;

            migrationBuilder.CreateTable(
                name: "Leden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verhuur",
                columns: table => new
                {
                    VerhuurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LidId = table.Column<int>(type: "int", nullable: false),
                    UitleenDatum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerugDatum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotaalPrijs = table.Column<float>(type: "real", nullable: false),
                    visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verhuur", x => x.VerhuurId);
                });

            migrationBuilder.CreateTable(
                name: "Verhuurlijn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerhuurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Prijs = table.Column<float>(type: "real", nullable: false),
                    UitleenDatum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerugDatum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verhuurlijn", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Leden");

            migrationBuilder.DropTable(
                name: "Verhuur");

            migrationBuilder.DropTable(
                name: "Verhuurlijn");
        }
    }
}
