using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BlogSpecsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogSpecs");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BlogItems",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "BlogItems",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "BlogItems");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "BlogItems");

            migrationBuilder.CreateTable(
                name: "BlogSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_BlogSpecs_BlogId",
                table: "BlogSpecs",
                column: "BlogId");
        }
    }
}
