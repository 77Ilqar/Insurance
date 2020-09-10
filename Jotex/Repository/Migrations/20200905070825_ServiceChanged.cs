using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ServiceChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "CategoryDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetails_ServiceId",
                table: "CategoryDetails",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Services_ServiceId",
                table: "CategoryDetails",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDetails_Services_ServiceId",
                table: "CategoryDetails");

            migrationBuilder.DropIndex(
                name: "IX_CategoryDetails_ServiceId",
                table: "CategoryDetails");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "CategoryDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDetails_Categories_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
