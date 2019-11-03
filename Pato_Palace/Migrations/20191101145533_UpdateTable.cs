using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUserId",
                table: "Busckets");

            migrationBuilder.DropForeignKey(
                name: "FK_Busckets_ShopNowProducts_ShopNowProductId",
                table: "Busckets");

            migrationBuilder.DropIndex(
                name: "IX_Busckets_AppUserId",
                table: "Busckets");

            migrationBuilder.DropIndex(
                name: "IX_Busckets_ShopNowProductId",
                table: "Busckets");

            migrationBuilder.DropColumn(
                name: "CountProduct",
                table: "Busckets");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Busckets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Busckets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountProduct",
                table: "Busckets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Busckets_AppUserId",
                table: "Busckets",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Busckets_ShopNowProductId",
                table: "Busckets",
                column: "ShopNowProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUserId",
                table: "Busckets",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Busckets_ShopNowProducts_ShopNowProductId",
                table: "Busckets",
                column: "ShopNowProductId",
                principalTable: "ShopNowProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
