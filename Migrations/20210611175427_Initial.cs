using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizzWhizzApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BusinessType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BusinessName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BusinessLocation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_businesses", x => x.BusinessId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "businesses");
        }
    }
}
