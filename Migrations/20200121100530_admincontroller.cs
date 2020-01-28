using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class admincontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 2, 11, 5, 29, 643, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 11, 11, 5, 29, 651, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 16, 11, 5, 29, 651, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 21, 11, 5, 29, 652, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 21, 8, 5, 29, 652, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 19, 11, 5, 29, 652, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Details", "ImageUrl", "Name" },
                values: new object[] { "Unic cats tshirt, hand made design", "/images/test1.jpg", "Cats TShirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/test2.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/test3.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 11, 27, 11, 32, 51, 934, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 6, 11, 32, 51, 942, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 11, 11, 32, 51, 942, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 16, 11, 32, 51, 942, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 16, 8, 32, 51, 942, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 14, 11, 32, 51, 942, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Details", "ImageUrl", "Name" },
                values: new object[] { "Unic unicorn tshirt, hand made design", " ", "Unicorn TShirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: " ");
        }
    }
}
