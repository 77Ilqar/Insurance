using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class CategoryDetailsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
