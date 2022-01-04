using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MootraWeb.Migrations
{
    public partial class Initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotion", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Emotion",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 1, new DateTime(2022, 1, 3, 17, 6, 58, 80, DateTimeKind.Local).AddTicks(555), "Happy" });

            migrationBuilder.InsertData(
                table: "Emotion",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 2, new DateTime(2022, 1, 3, 17, 6, 58, 80, DateTimeKind.Local).AddTicks(588), "Sad" });

            migrationBuilder.InsertData(
                table: "Emotion",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 3, new DateTime(2022, 1, 3, 17, 6, 58, 80, DateTimeKind.Local).AddTicks(591), "Anxious" });

            migrationBuilder.InsertData(
                table: "Emotion",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[] { 4, new DateTime(2022, 1, 3, 17, 6, 58, 80, DateTimeKind.Local).AddTicks(592), "Angry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emotion");
        }
    }
}
