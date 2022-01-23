using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Backend.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Measure",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Measure",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
