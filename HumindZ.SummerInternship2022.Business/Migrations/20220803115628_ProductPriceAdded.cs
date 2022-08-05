using Microsoft.EntityFrameworkCore.Migrations;

namespace HumindZ.SummerInternship2022.Business.Migrations
{
    public partial class ProductPriceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductPrice",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Product");
        }
    }
}
