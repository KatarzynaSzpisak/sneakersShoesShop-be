using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class orderdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 4, 14, 43, 24, 708, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 13, 14, 43, 24, 719, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 18, 14, 43, 24, 719, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaterialId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 23, 14, 43, 24, 720, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 23, 11, 43, 24, 720, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 21, 14, 43, 24, 720, DateTimeKind.Local).AddTicks(1580));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 4, 14, 41, 28, 641, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 13, 14, 41, 28, 652, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 18, 14, 41, 28, 652, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaterialId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 23, 14, 41, 28, 652, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 23, 11, 41, 28, 652, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 21, 14, 41, 28, 652, DateTimeKind.Local).AddTicks(7240));
        }
    }
}
