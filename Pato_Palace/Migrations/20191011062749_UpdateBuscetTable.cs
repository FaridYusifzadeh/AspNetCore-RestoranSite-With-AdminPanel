using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class UpdateBuscetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUsersId",
                table: "Busckets");

            migrationBuilder.DropIndex(
                name: "IX_Busckets_AppUsersId",
                table: "Busckets");

            migrationBuilder.DropColumn(
                name: "AppUsersId",
                table: "Busckets");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Busckets",
                nullable: true,
                oldClrType: typeof(int),
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

            migrationBuilder.AddForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUserId",
                table: "Busckets",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUserId",
                table: "Busckets");

            migrationBuilder.DropIndex(
                name: "IX_Busckets_AppUserId",
                table: "Busckets");

            migrationBuilder.DropColumn(
                name: "CountProduct",
                table: "Busckets");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Busckets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUsersId",
                table: "Busckets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Busckets_AppUsersId",
                table: "Busckets",
                column: "AppUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Busckets_AspNetUsers_AppUsersId",
                table: "Busckets",
                column: "AppUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
