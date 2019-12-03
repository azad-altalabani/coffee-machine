using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMachine.Dal.Migrations
{
    public partial class DrinkSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Drinks",
                new[] { "Code", "Description" },
                new[] { "THE", "Thé" });

            migrationBuilder.InsertData(
                "Drinks",
                new[] { "Code", "Description" },
                new[] { "COF", "Café" });

            migrationBuilder.InsertData(
                "Drinks",
                new[] { "Code", "Description" },
                new[] { "CHO", "Chocolat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
