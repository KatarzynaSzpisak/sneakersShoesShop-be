using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class create_new_row : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "OrderRows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "OrderRows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderRows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderRows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "OrderRows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Registered",
                value: new DateTime(2019, 12, 17, 1, 15, 53, 945, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Registered",
                value: new DateTime(2020, 1, 26, 1, 15, 53, 952, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Registered",
                value: new DateTime(2020, 1, 31, 1, 15, 53, 952, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 2, 5, 1, 15, 53, 953, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 2, 4, 22, 15, 53, 953, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 2, 3, 1, 15, 53, 953, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ColorId",
                table: "OrderRows",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_MaterialId",
                table: "OrderRows",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_SizeId",
                table: "OrderRows",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Colors_ColorId",
                table: "OrderRows",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Materials_MaterialId",
                table: "OrderRows",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Products_ProductId",
                table: "OrderRows",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Sizes_SizeId",
                table: "OrderRows",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Colors_ColorId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Materials_MaterialId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Products_ProductId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Sizes_SizeId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_ColorId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_MaterialId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_SizeId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "OrderRows");

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
                column: "Created",
                value: new DateTime(2020, 2, 5, 0, 51, 36, 688, DateTimeKind.Local).AddTicks(4620));

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
    }
}
