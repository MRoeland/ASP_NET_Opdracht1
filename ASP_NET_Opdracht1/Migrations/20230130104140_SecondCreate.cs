using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_Opdracht1.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "visible",
                table: "Verhuurlijn",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "visible",
                table: "Verhuur",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "visible",
                table: "Leden",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "visible",
                table: "Films",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "visible",
                table: "Verhuurlijn");

            migrationBuilder.DropColumn(
                name: "visible",
                table: "Verhuur");

            migrationBuilder.DropColumn(
                name: "visible",
                table: "Leden");

            migrationBuilder.DropColumn(
                name: "visible",
                table: "Films");
        }
    }
}
