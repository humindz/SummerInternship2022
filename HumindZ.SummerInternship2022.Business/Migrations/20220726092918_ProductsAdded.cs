using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumindZ.SummerInternship2022.Business.Migrations
{
    public partial class ProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductCategoryType = table.Column<string>(nullable: true),
                    ProductShortDescription = table.Column<string>(nullable: true),
                    ProductLongDescription = table.Column<string>(nullable: true),
                    ProductVersion = table.Column<string>(nullable: true),
                    ProductVersionDate = table.Column<DateTime>(nullable: false),
                    ProductVersionNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDocumentDocumentationLinks",
                columns: table => new
                {
                    ProductDocumentDocumentationLinksId = table.Column<Guid>(nullable: false),
                    ProductDocumentDocumentationLinksName = table.Column<string>(nullable: true),
                    ProductDocumentDocumentationLinksDescription = table.Column<string>(nullable: true),
                    ProductDocumentDocumentationFile = table.Column<string>(nullable: true),
                    ProductDocumentLinksUrl = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDocumentDocumentationLinks", x => x.ProductDocumentDocumentationLinksId);
                    table.ForeignKey(
                        name: "FK_ProductDocumentDocumentationLinks_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDocumentExamples",
                columns: table => new
                {
                    ProductDocumentExamplesId = table.Column<Guid>(nullable: false),
                    ProductDocumentExampleName = table.Column<string>(nullable: true),
                    ProductDocumentExampleFile = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDocumentExamples", x => x.ProductDocumentExamplesId);
                    table.ForeignKey(
                        name: "FK_ProductDocumentExamples_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDocumentDocumentationLinks_ProductId",
                table: "ProductDocumentDocumentationLinks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDocumentExamples_ProductId",
                table: "ProductDocumentExamples",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDocumentDocumentationLinks");

            migrationBuilder.DropTable(
                name: "ProductDocumentExamples");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
