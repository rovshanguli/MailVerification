using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonMigration.Migrations
{
    public partial class CreateAccountTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 16, 51, 673, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 16, 51, 673, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 16, 51, 673, DateTimeKind.Local).AddTicks(7996));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 15, 30, 437, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 15, 30, 438, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 6, 0, 15, 30, 438, DateTimeKind.Local).AddTicks(4855));
        }
    }
}
