using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class orderdetailsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 4, 14, 44, 50, 13, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 13, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 18, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ColorId", "MaterialId", "OrderId", "ProductId", "Quantity", "SizeId" },
                values: new object[] { 2, 1, 1, 3, 1, 10, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 23, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 23, 11, 44, 50, 24, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 21, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(8930));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
