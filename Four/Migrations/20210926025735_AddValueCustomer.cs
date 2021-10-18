using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Four.Migrations
{
    public partial class AddValueCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DateOfBirth", "Gender", "Name", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Ngã 4 Khuất Duy Tiến", null, new DateTime(2021, 9, 26, 9, 57, 34, 563, DateTimeKind.Local).AddTicks(9807), new DateTime(2021, 9, 26, 9, 57, 34, 564, DateTimeKind.Local).AddTicks(9713), 1, "Thúy Thị Kiều", 0, null, null },
                    { 2, "Ngã 3 Khuất Duy Tiến", null, new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(259), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(293), 1, "Thúy Thị Vân", 0, null, null },
                    { 3, "Ngã 4 Trần Duy Hưng", null, new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(314), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(316), 0, "Chí Phèo", 0, null, null },
                    { 4, "Ngã 4 Thanh Xuân", null, new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(317), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(318), 0, "Lão Hạc", 0, null, null },
                    { 5, "Ngã 3 Dịch Vọng", null, new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(507), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(509), 0, "Cậu Vàng", 0, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
