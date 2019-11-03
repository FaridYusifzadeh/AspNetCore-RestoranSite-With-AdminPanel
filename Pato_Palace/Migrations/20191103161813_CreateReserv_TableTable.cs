using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pato_Palace.Migrations
{
    public partial class CreateReserv_TableTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Busckets",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "ShopNowProductId",
                table: "Busckets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Reserv_Tables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(maxLength: 30, nullable: false),
                    Time = table.Column<string>(maxLength: 30, nullable: false),
                    Persone_Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserv_Tables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserv_Tables");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Busckets",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ShopNowProductId",
                table: "Busckets",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
