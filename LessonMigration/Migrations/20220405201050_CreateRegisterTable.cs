using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonMigration.Migrations
{
    public partial class CreateRegisterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 10, 50, 529, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 10, 50, 529, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 10, 50, 529, DateTimeKind.Local).AddTicks(9476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 5, 18, 41, 31, 878, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 5, 18, 41, 31, 878, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 5, 18, 41, 31, 878, DateTimeKind.Local).AddTicks(7195));
        }
    }
}
