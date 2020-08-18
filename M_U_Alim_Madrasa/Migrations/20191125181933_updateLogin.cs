using Microsoft.EntityFrameworkCore.Migrations;

namespace M_U_Alim_Madrasa.Migrations
{
    public partial class updateLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "login",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "login");
        }
    }
}
