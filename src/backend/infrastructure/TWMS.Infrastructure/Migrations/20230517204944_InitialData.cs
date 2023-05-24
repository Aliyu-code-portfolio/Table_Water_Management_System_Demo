using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TWMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuarantorAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuarantorAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionCost = table.Column<double>(type: "float", nullable: false),
                    DateProduced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RetailPricePerUnit = table.Column<double>(type: "float", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerAddressId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerAddresses_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "CustomerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guarantor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GuarantorAddressId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guarantor_GuarantorAddress_GuarantorAddressId",
                        column: x => x.GuarantorAddressId,
                        principalTable: "GuarantorAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalCost = table.Column<decimal>(type: "money", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StaffAddressId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuarantorId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Guarantor_GuarantorId",
                        column: x => x.GuarantorId,
                        principalTable: "Guarantor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_StaffAddresses_StaffAddressId",
                        column: x => x.StaffAddressId,
                        principalTable: "StaffAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTypes_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CustomerAddresses",
                columns: new[] { "Id", "AreaLocality", "BuildingNumber", "City", "CreatedBy", "CreatedDate", "DateModified", "Landmark", "ModifiedBy", "State_Province", "StreetName", "Zip_PostalCode" },
                values: new object[,]
                {
                    { 1, "Area 1", 99, "City 1", "Jane Smith", new DateTime(2023, 5, 5, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 4, 25, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3085), "Landmark 1", "John Doe", "State 1", "Street 1", 57185 },
                    { 2, "Area 2", 29, "City 2", "Jane Smith", new DateTime(2023, 5, 4, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 4, 20, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3106), "Landmark 2", "John Doe", "State 2", "Street 2", 15239 },
                    { 3, "Area 3", 66, "City 3", "Jane Smith", new DateTime(2023, 4, 20, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 5, 8, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3117), "Landmark 3", "John Doe", "State 3", "Street 3", 22578 },
                    { 4, "Area 4", 45, "City 4", "Jane Smith", new DateTime(2023, 5, 13, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 5, 14, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3129), "Landmark 4", "John Doe", "State 4", "Street 4", 83692 },
                    { 5, "Area 5", 70, "City 5", "Jane Smith", new DateTime(2023, 5, 15, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 4, 30, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3141), "Landmark 5", "John Doe", "State 5", "Street 5", 17667 },
                    { 6, "Area 6", 48, "City 6", "Jane Smith", new DateTime(2023, 4, 23, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 4, 24, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3154), "Landmark 6", "John Doe", "State 6", "Street 6", 22509 },
                    { 7, "Area 7", 88, "City 7", "Jane Smith", new DateTime(2023, 5, 1, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 5, 8, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3164), "Landmark 7", "John Doe", "State 7", "Street 7", 68152 },
                    { 8, "Area 8", 10, "City 8", "Jane Smith", new DateTime(2023, 4, 21, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 5, 11, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3173), "Landmark 8", "John Doe", "State 8", "Street 8", 55500 },
                    { 9, "Area 9", 44, "City 9", "Jane Smith", new DateTime(2023, 4, 24, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 4, 21, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3183), "Landmark 9", "John Doe", "State 9", "Street 9", 40656 },
                    { 10, "Area 10", 16, "City 10", "Jane Smith", new DateTime(2023, 5, 16, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 5, 12, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3194), "Landmark 10", "John Doe", "State 10", "Street 10", 47143 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthday", "CreatedBy", "CreatedDate", "CustomerAddressId", "DateModified", "EmailAddress", "FullName", "ModifiedBy", "PhoneNo" },
                values: new object[,]
                {
                    { new Guid("0352fcda-393a-48a0-83a0-9178520f6af6"), new DateTime(1999, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2367), "Jane Smith", new DateTime(2023, 5, 14, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2365), 3, new DateTime(2023, 5, 13, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2364), "customer3@example.com", "Customer 3", "John Doe", "1234567890" },
                    { new Guid("31812621-52da-4a8d-b4b8-4e7ea885c651"), new DateTime(1976, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2435), "Jane Smith", new DateTime(2023, 4, 23, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2433), 10, new DateTime(2023, 4, 25, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2431), "customer10@example.com", "Customer 10", "John Doe", "1234567890" },
                    { new Guid("393f3cc7-d21c-4c7f-996e-98d0c8d5e8b0"), new DateTime(2005, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2344), "Jane Smith", new DateTime(2023, 5, 1, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2327), 1, new DateTime(2023, 5, 7, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2316), "customer1@example.com", "Customer 1", "John Doe", "1234567890" },
                    { new Guid("651ce050-0a72-4c98-8516-a480046f7955"), new DateTime(1995, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2412), "Jane Smith", new DateTime(2023, 5, 13, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2411), 7, new DateTime(2023, 5, 15, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2409), "customer7@example.com", "Customer 7", "John Doe", "1234567890" },
                    { new Guid("68595538-779b-46b0-bd58-2f0c8027bfa0"), new DateTime(1995, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2360), "Jane Smith", new DateTime(2023, 5, 15, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2358), 2, new DateTime(2023, 4, 27, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2356), "customer2@example.com", "Customer 2", "John Doe", "1234567890" },
                    { new Guid("8adb2040-5ab8-47b9-9a76-a4d58ec90ce3"), new DateTime(2004, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2419), "Jane Smith", new DateTime(2023, 5, 4, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2417), 8, new DateTime(2023, 5, 15, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2416), "customer8@example.com", "Customer 8", "John Doe", "1234567890" },
                    { new Guid("a4f21388-e64b-4263-9c57-ba4e8367dab7"), new DateTime(1998, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2396), "Jane Smith", new DateTime(2023, 4, 29, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2395), 5, new DateTime(2023, 5, 16, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2393), "customer5@example.com", "Customer 5", "John Doe", "1234567890" },
                    { new Guid("b238ee47-c577-421e-b4d5-d468a018c572"), new DateTime(1995, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2426), "Jane Smith", new DateTime(2023, 5, 9, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2425), 9, new DateTime(2023, 4, 18, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2423), "customer9@example.com", "Customer 9", "John Doe", "1234567890" },
                    { new Guid("e75795ef-cbe8-4a84-8de1-9e493281bab8"), new DateTime(1968, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2374), "Jane Smith", new DateTime(2023, 5, 12, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2373), 4, new DateTime(2023, 5, 2, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2372), "customer4@example.com", "Customer 4", "John Doe", "1234567890" },
                    { new Guid("ff676444-0d3c-4eea-8d27-c97cea12ee17"), new DateTime(1985, 5, 17, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2406), "Jane Smith", new DateTime(2023, 4, 22, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2404), 6, new DateTime(2023, 4, 20, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(2403), "customer6@example.com", "Customer 6", "John Doe", "1234567890" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor_GuarantorAddressId",
                table: "Guarantor",
                column: "GuarantorAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_InventoryId",
                table: "ProductTypes",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_GuarantorId",
                table: "Staffs",
                column: "GuarantorId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_StaffAddressId",
                table: "Staffs",
                column: "StaffAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Guarantor");

            migrationBuilder.DropTable(
                name: "StaffAddresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "GuarantorAddress");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");
        }
    }
}
