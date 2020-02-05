using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineTShirtShop.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    Registered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SizeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ActualCost = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    ColorId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderRows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderRows_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRows_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName" },
                values: new object[] { 1, "red" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName" },
                values: new object[] { 2, "green" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName" },
                values: new object[] { 3, "blue" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName" },
                values: new object[] { 4, "black" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Registered", "Telephone" },
                values: new object[] { 1, "tanya.l@l.se", "Tanya", "L", new DateTime(2019, 12, 17, 1, 19, 58, 786, DateTimeKind.Local).AddTicks(2710), 123456789 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Registered", "Telephone" },
                values: new object[] { 2, "dima.l@l.se", "Dima", "L", new DateTime(2020, 1, 26, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(3990), 123456789 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Registered", "Telephone" },
                values: new object[] { 3, "kolya.l@l.com", "Kolya", "L", new DateTime(2020, 1, 31, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(4160), 123456789 });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialName" },
                values: new object[] { 1, "cotton" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialName" },
                values: new object[] { 2, "leather" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 1, "XS" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 2, "S" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 3, "M" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 4, "L" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 5, "XL" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeName" },
                values: new object[] { 6, "XXL" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CustomerId", "Status" },
                values: new object[] { 1, new DateTime(2020, 2, 5, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(7050), 1, "BASKET" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CustomerId", "Status" },
                values: new object[] { 2, new DateTime(2020, 2, 4, 22, 19, 58, 794, DateTimeKind.Local).AddTicks(7980), 2, "onpaid" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CustomerId", "Status" },
                values: new object[] { 3, new DateTime(2020, 2, 3, 1, 19, 58, 794, DateTimeKind.Local).AddTicks(8090), 3, "basket" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActualCost", "ColorId", "Details", "ImageUrl", "MaterialId", "Name", "Price", "SizeId" },
                values: new object[] { 1, 100m, 1, "Unik cats tshirt, hand made design", "/images/test1.jpg", 1, "Cats TShirt", 100m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActualCost", "ColorId", "Details", "ImageUrl", "MaterialId", "Name", "Price", "SizeId" },
                values: new object[] { 2, 90m, 2, "Unik classic tshirt, hand made design", "/images/test2.jpg", 2, "Classic TShirt", 90m, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActualCost", "ColorId", "Details", "ImageUrl", "MaterialId", "Name", "Price", "SizeId" },
                values: new object[] { 3, 80m, 3, "Unik unisex tshirt, hand made design", "/images/test3.jpg", 1, "Unisex TShirt", 80m, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ColorId",
                table: "OrderDetails",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MaterialId",
                table: "OrderDetails",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SizeId",
                table: "OrderDetails",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ColorId",
                table: "OrderRows",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_MaterialId",
                table: "OrderRows",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_SizeId",
                table: "OrderRows",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialId",
                table: "Products",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderRows");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
