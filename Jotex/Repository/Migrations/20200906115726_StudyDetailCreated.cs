using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class StudyDetailCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "StudySingles");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "StudySingles",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text1",
                table: "StudySingles",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "StudySingles",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text3",
                table: "StudySingles",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text4",
                table: "StudySingles",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "StudyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: false),
                    Key = table.Column<string>(maxLength: 200, nullable: false),
                    Value = table.Column<string>(maxLength: 200, nullable: false),
                    StudySingleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyDetails_StudySingles_StudySingleId",
                        column: x => x.StudySingleId,
                        principalTable: "StudySingles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudyDetails_StudySingleId",
                table: "StudyDetails",
                column: "StudySingleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudyDetails");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Text1",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Text3",
                table: "StudySingles");

            migrationBuilder.DropColumn(
                name: "Text4",
                table: "StudySingles");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "StudySingles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "StudySingles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "StudySingles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "StudySingles",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "StudySingles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
