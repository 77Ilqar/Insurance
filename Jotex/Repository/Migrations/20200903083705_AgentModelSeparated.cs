using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AgentModelSeparated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentPictures_Agents_AgentId",
                table: "AgentPictures");

            migrationBuilder.DropIndex(
                name: "IX_AgentPictures_AgentId",
                table: "AgentPictures");

            migrationBuilder.DropColumn(
                name: "Limit",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "AgentPictures");

            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "AgentPictures");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Limit",
                table: "Agents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "AgentPictures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "AgentPictures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AgentPictures_AgentId",
                table: "AgentPictures",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AgentPictures_Agents_AgentId",
                table: "AgentPictures",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
