using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 4, 14, 32, 49, 45, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 13, 14, 32, 49, 56, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 18, 14, 32, 49, 56, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialName" },
                values: new object[] { 1, "cotton" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialName" },
                values: new object[] { 2, "leather" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 23, 14, 32, 49, 56, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 23, 11, 32, 49, 56, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 21, 14, 32, 49, 56, DateTimeKind.Local).AddTicks(8620));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 4, 14, 23, 4, 23, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 13, 14, 23, 4, 35, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 18, 14, 23, 4, 35, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ColorId", "MaterialId", "OrderId", "ProductId", "Quantity", "SizeId" },
                values: new object[] { 1, 1, 1, 3, 1, 10, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 23, 14, 23, 4, 35, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 23, 11, 23, 4, 35, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 21, 14, 23, 4, 35, DateTimeKind.Local).AddTicks(4500));
        }
    }
}
