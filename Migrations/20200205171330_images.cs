using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 17, 18, 13, 29, 836, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 26, 18, 13, 29, 843, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 31, 18, 13, 29, 843, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 2, 5, 18, 13, 29, 844, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 2, 5, 15, 13, 29, 844, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 2, 3, 18, 13, 29, 844, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/assets/images/test1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/assets/images/test2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/assets/images/test3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 17, 1, 19, 58, 786, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 26, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 31, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 2, 5, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 2, 4, 22, 19, 58, 794, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 2, 3, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/test1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/test2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/test3.jpg");
        }
    }
}
