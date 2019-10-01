using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class UpdateMain_MenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Main_Menus");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Main_Menus");

            migrationBuilder.DropColumn(
                name: "Product_Content",
                table: "Main_Menus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Main_Menus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Main_Menus",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Content",
                table: "Main_Menus",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }
    }
}
