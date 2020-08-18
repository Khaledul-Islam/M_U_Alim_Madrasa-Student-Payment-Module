using Microsoft.EntityFrameworkCore.Migrations;

namespace M_U_Alim_Madrasa.Migrations
{
    public partial class addMorePropertiestoPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Paid",
                table: "payment",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "payment");
        }
    }
}
