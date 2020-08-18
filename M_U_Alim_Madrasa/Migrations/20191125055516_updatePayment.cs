using Microsoft.EntityFrameworkCore.Migrations;

namespace M_U_Alim_Madrasa.Migrations
{
    public partial class updatePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Due",
                table: "payment",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "payment",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Due",
                table: "payment");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "payment");
        }
    }
}
