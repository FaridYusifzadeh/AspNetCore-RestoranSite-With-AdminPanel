using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class UpdateReservTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Busckets");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Reserv_Tables",
                maxLength: 170,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Reserv_Tables");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Busckets",
                nullable: true);
        }
    }
}
