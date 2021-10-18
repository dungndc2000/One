using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Four.Migrations
{
    public partial class AddValueTableThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 6, 45, 479, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8670), new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8721), new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8724), new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8726), new DateTime(2021, 9, 26, 10, 6, 45, 480, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreateBy", "CreateDate", "CustomerID", "InvoiceDay", "Price", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(1029), 1, null, 23000, 0, null, null },
                    { 2, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(1580), 2, null, 25000, 0, null, null },
                    { 3, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(1605), 3, null, 50000, 0, null, null },
                    { 4, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(1607), 4, null, 27000, 0, null, null },
                    { 5, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(1608), 5, null, 40000, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Name", "Price", "Status", "Unit", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(2071), "Sữa đặc ông thọ", 23000, 0, "Lon", null, null },
                    { 2, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(2810), "Kẹo dẻo Hồng Hà", 20000, 0, "Gói", null, null },
                    { 3, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(2836), "Bánh xốp Kinh Đô", 75000, 0, "Hộp", null, null },
                    { 4, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(2838), "Bánh xốp Luxury", 120000, 0, "Hộp", null, null },
                    { 5, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(2840), "Đường trắng Quy Hòa", 15000, 0, "Gói", null, null }
                });

            migrationBuilder.InsertData(
                table: "DetailsInvoices",
                columns: new[] { "Id", "Count", "CreateBy", "CreateDate", "InvoiceID", "ProductID", "Status", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 3, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(3959), 1, 1, 0, null, null },
                    { 2, 2, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(5017), 2, 2, 0, null, null },
                    { 3, 1, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(5062), 3, 3, 0, null, null },
                    { 4, 5, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(5064), 4, 4, 0, null, null },
                    { 5, 7, null, new DateTime(2021, 9, 26, 10, 6, 45, 482, DateTimeKind.Local).AddTicks(5065), 5, 5, 0, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetailsInvoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DetailsInvoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DetailsInvoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DetailsInvoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DetailsInvoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 57, 34, 563, DateTimeKind.Local).AddTicks(9807), new DateTime(2021, 9, 26, 9, 57, 34, 564, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(259), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(314), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(317), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "DateOfBirth" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(507), new DateTime(2021, 9, 26, 9, 57, 34, 565, DateTimeKind.Local).AddTicks(509) });
        }
    }
}
