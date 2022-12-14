using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Furnits.Data.Migrations
{
    public partial class CreateDivan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BackDegree = table.Column<int>(type: "integer", nullable: false),
                    ProductsArticle = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divans_Products_ProductsArticle",
                        column: x => x.ProductsArticle,
                        principalTable: "Products",
                        principalColumn: "Article",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divans_ProductsArticle",
                table: "Divans",
                column: "ProductsArticle",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divans");
        }
    }
}
