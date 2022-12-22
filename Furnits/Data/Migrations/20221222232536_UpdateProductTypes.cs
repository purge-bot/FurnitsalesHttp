using Microsoft.EntityFrameworkCore.Migrations;

namespace Furnits.Data.Migrations
{
    public partial class UpdateProductTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeCode",
                table: "ProductTypes",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_TypeCode",
                table: "ProductTypes",
                column: "TypeCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_TypeCode",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "ProductTypes");
        }
    }
}
