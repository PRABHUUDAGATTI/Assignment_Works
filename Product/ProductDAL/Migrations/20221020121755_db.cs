using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDAL.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_products_Article",
                table: "articles");

            migrationBuilder.RenameColumn(
                name: "Article",
                table: "articles",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_articles_Article",
                table: "articles",
                newName: "IX_articles_productId");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_products_productId",
                table: "articles",
                column: "productId",
                principalTable: "products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_products_productId",
                table: "articles");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_articles_productId",
                table: "articles",
                newName: "IX_articles_Article");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_products_Article",
                table: "articles",
                column: "Article",
                principalTable: "products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
