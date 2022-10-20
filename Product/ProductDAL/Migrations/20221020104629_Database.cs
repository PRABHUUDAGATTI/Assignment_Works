using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDAL.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "colours",
                columns: table => new
                {
                    colourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    colourCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colourName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colours", x => x.colourID);
                });

            migrationBuilder.CreateTable(
                name: "sizeScales",
                columns: table => new
                {
                    sizScaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sizeScaleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizeScales", x => x.sizScaleId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productYear = table.Column<int>(type: "int", nullable: false),
                    sizScaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    channelId = table.Column<int>(type: "int", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_products_sizeScales_sizScaleId",
                        column: x => x.sizScaleId,
                        principalTable: "sizeScales",
                        principalColumn: "sizScaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    articleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    articleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Article = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.articleId);
                    table.ForeignKey(
                        name: "FK_articles_colours_colourID",
                        column: x => x.colourID,
                        principalTable: "colours",
                        principalColumn: "colourID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articles_products_Article",
                        column: x => x.Article,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articles_Article",
                table: "articles",
                column: "Article");

            migrationBuilder.CreateIndex(
                name: "IX_articles_colourID",
                table: "articles",
                column: "colourID");

            migrationBuilder.CreateIndex(
                name: "IX_products_sizScaleId",
                table: "products",
                column: "sizScaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.DropTable(
                name: "colours");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "sizeScales");
        }
    }
}
