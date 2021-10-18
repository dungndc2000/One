using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Two.Migrations
{
    public partial class AddValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Count", "CreateBy", "CreateDate", "BookID", "PublishDate", "Status", "UpdateBy", "UpdateDate" },
                values: new object[] { 1, 2000, null, new DateTime(2021, 9, 16, 14, 56, 26, 551, DateTimeKind.Local).AddTicks(5259), "Dung Bui", new DateTime(2021, 9, 16, 14, 56, 26, 552, DateTimeKind.Local).AddTicks(4161), 0, null, null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Count", "CreateBy", "CreateDate", "BookID", "PublishDate", "Status", "UpdateBy", "UpdateDate" },
                values: new object[] { 2, 2005, null, new DateTime(2021, 9, 16, 14, 56, 26, 552, DateTimeKind.Local).AddTicks(4456), "Jane Doe", new DateTime(2021, 9, 16, 14, 56, 26, 552, DateTimeKind.Local).AddTicks(4493), 0, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
