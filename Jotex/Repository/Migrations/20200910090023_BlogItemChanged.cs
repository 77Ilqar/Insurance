using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BlogItemChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "BlogItems",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "BlogItems",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "BlogItems");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "BlogItems");
        }
    }
}
