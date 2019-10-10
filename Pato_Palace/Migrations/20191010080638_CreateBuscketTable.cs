using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class CreateBuscketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Busckets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppUserId = table.Column<int>(nullable: true),
                    AppUsersId = table.Column<string>(nullable: true),
                    ShopNowProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Busckets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Busckets_AspNetUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Busckets_ShopNowProducts_ShopNowProductId",
                        column: x => x.ShopNowProductId,
                        principalTable: "ShopNowProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Busckets_AppUsersId",
                table: "Busckets",
                column: "AppUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Busckets_ShopNowProductId",
                table: "Busckets",
                column: "ShopNowProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Busckets");
        }
    }
}
