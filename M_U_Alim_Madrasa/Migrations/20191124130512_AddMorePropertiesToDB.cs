using Microsoft.EntityFrameworkCore.Migrations;

namespace M_U_Alim_Madrasa.Migrations
{
    public partial class AddMorePropertiesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roll",
                table: "payment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roll",
                table: "payment");
        }
    }
}
