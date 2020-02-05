using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class orderrow3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 17, 0, 51, 36, 679, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 26, 0, 51, 36, 688, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 31, 0, 51, 36, 688, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Status" },
                values: new object[] { new DateTime(2020, 2, 5, 0, 51, 36, 688, DateTimeKind.Local).AddTicks(4620), "BASKET" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 2, 4, 21, 51, 36, 688, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 2, 3, 0, 51, 36, 688, DateTimeKind.Local).AddTicks(5540));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 17, 0, 34, 31, 279, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 26, 0, 34, 31, 287, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 31, 0, 34, 31, 287, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ColorId", "MaterialId", "OrderId", "ProductId", "Quantity", "SizeId" },
                values: new object[] { 1, 1, 2, 3, 1, 10, 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ColorId", "MaterialId", "OrderId", "ProductId", "Quantity", "SizeId" },
                values: new object[] { 2, 1, 1, 3, 1, 70, 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ColorId", "MaterialId", "OrderId", "ProductId", "Quantity", "SizeId" },
                values: new object[] { 3, 3, 2, 2, 3, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Status" },
                values: new object[] { new DateTime(2020, 2, 5, 0, 34, 31, 287, DateTimeKind.Local).AddTicks(6090), "paid" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 2, 4, 21, 34, 31, 287, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 2, 3, 0, 34, 31, 287, DateTimeKind.Local).AddTicks(6940));
        }
    }
}
