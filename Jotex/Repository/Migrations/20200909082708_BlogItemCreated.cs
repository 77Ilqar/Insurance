using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BlogItemCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    ShortSubtitle = table.Column<string>(maxLength: 300, nullable: false),
                    Subtitle = table.Column<string>(maxLength: 1000, nullable: false),
                    Quote = table.Column<string>(maxLength: 300, nullable: false),
                    WrittenBy = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(maxLength: 1000, nullable: false),
                    Subtext = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Video = table.Column<string>(maxLength: 300, nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogSpecs_BlogItems_BlogId",
                        column: x => x.BlogId,
                        principalTable: "BlogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_BlogItems_BlogId",
                        column: x => x.BlogId,
                        principalTable: "BlogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogSpecs_BlogId",
                table: "BlogSpecs",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogSpecs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "BlogItems");
        }
    }
}
