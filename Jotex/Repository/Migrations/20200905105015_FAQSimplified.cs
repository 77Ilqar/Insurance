using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class FAQSimplified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "FAQs");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "FAQs",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "FAQs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FAQs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "FAQs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "FAQs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
