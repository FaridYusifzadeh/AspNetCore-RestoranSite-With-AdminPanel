using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class UpdateReserv_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reserv_Tables",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reserv_Tables");
        }
    }
}
