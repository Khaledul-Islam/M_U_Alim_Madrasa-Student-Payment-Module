using Microsoft.EntityFrameworkCore.Migrations;

namespace M_U_Alim_Madrasa.Migrations
{
    public partial class addmoretoPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Roll",
                table: "payment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Roll",
                table: "payment",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
