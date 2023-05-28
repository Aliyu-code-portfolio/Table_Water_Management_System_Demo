using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TWMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedModelAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "GuarantorAddress",
                columns: table => new
                {
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuarantorAddress", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionCost = table.Column<decimal>(type: "money", nullable: false),
                    RetailPricePerUnit = table.Column<decimal>(type: "money", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffAddresses",
                columns: table => new
                {
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAddresses", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerAddressCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerAddresses_CustomerAddressCustomerId",
                        column: x => x.CustomerAddressCustomerId,
                        principalTable: "CustomerAddresses",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffAddressStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_StaffAddresses_StaffAddressStaffId",
                        column: x => x.StaffAddressStaffId,
                        principalTable: "StaffAddresses",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalCost = table.Column<decimal>(type: "money", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                name: "Guarantor",
                columns: table => new
                {
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuarantorAddressStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Guarantor_GuarantorAddress_GuarantorAddressStaffId",
                        column: x => x.GuarantorAddressStaffId,
                        principalTable: "GuarantorAddress",
                        principalColumn: "StaffId");
                    table.ForeignKey(
                        name: "FK_Guarantor_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTypes_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CustomerAddresses",
                columns: new[] { "CustomerId", "AreaLocality", "BuildingNumber", "City", "CreatedBy", "CreatedDate", "DateModified", "Landmark", "ModifiedBy", "State_Province", "StreetName", "Zip_PostalCode" },
                values: new object[,]
                {
                    { new Guid("11af2960-8a50-4979-a9c3-b32bc68eba38"), "Area 2", 60, "City 2", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 2", "John Doe", "State 2", "Street 2", 34548 },
                    { new Guid("20f09330-8204-4e3a-b343-fd0d6a3ccfa7"), "Area 7", 13, "City 7", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 26, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 7", "John Doe", "State 7", "Street 7", 33555 },
                    { new Guid("2cf1decd-666b-4d39-bb31-78e9fdc432ed"), "Area 9", 84, "City 9", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5772), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5770), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 9", "John Doe", "State 9", "Street 9", 16603 },
                    { new Guid("9556a60d-fbbe-4819-937c-832a8b66b6b8"), "Area 8", 11, "City 8", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5761), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 8", "John Doe", "State 8", "Street 8", 31658 },
                    { new Guid("a3c4bd1c-081a-4a99-8ca4-886208a118d3"), "Area 10", 45, "City 10", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 13, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 10", "John Doe", "State 10", "Street 10", 66746 },
                    { new Guid("a5f3017d-9f83-44fd-9f95-caa571f76abb"), "Area 3", 16, "City 3", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5663), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 3", "John Doe", "State 3", "Street 3", 83522 },
                    { new Guid("bbd4474e-7adc-4fbb-ba9e-428c51d88531"), "Area 6", 67, "City 6", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 15, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 6", "John Doe", "State 6", "Street 6", 66278 },
                    { new Guid("e24303f7-293e-467b-b236-13e50f3d90d2"), "Area 4", 42, "City 4", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 4", "John Doe", "State 4", "Street 4", 16040 },
                    { new Guid("ef73f0aa-8055-4314-9969-7f31c1845950"), "Area 1", 78, "City 1", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 17, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 1", "John Doe", "State 1", "Street 1", 66430 },
                    { new Guid("f129c122-d315-473c-b641-370bc022b031"), "Area 5", 3, "City 5", "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 26, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 1, 0, 0, 0)), "Landmark 5", "John Doe", "State 5", "Street 5", 78123 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthday", "CreatedBy", "CreatedDate", "CustomerAddressCustomerId", "DateModified", "EmailAddress", "FullName", "ModifiedBy", "PhoneNo" },
                values: new object[,]
                {
                    { new Guid("11af2960-8a50-4979-a9c3-b32bc68eba38"), new DateTime(1994, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5344), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 7, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5340), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5338), new TimeSpan(0, 1, 0, 0, 0)), "customer2@example.com", "Customer 2", "John Doe", "1234567890" },
                    { new Guid("20f09330-8204-4e3a-b343-fd0d6a3ccfa7"), new DateTime(2001, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5397), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 12, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 1, 0, 0, 0)), "customer7@example.com", "Customer 7", "John Doe", "1234567890" },
                    { new Guid("2cf1decd-666b-4d39-bb31-78e9fdc432ed"), new DateTime(1981, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5417), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 11, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 19, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5412), new TimeSpan(0, 1, 0, 0, 0)), "customer9@example.com", "Customer 9", "John Doe", "1234567890" },
                    { new Guid("9556a60d-fbbe-4819-937c-832a8b66b6b8"), new DateTime(1993, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5407), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 15, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 1, 0, 0, 0)), "customer8@example.com", "Customer 8", "John Doe", "1234567890" },
                    { new Guid("a3c4bd1c-081a-4a99-8ca4-886208a118d3"), new DateTime(1976, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5427), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 12, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 11, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 1, 0, 0, 0)), "customer10@example.com", "Customer 10", "John Doe", "1234567890" },
                    { new Guid("a5f3017d-9f83-44fd-9f95-caa571f76abb"), new DateTime(1994, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5354), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 1, 0, 0, 0)), "customer3@example.com", "Customer 3", "John Doe", "1234567890" },
                    { new Guid("bbd4474e-7adc-4fbb-ba9e-428c51d88531"), new DateTime(1975, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5385), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 15, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5383), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 9, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 1, 0, 0, 0)), "customer6@example.com", "Customer 6", "John Doe", "1234567890" },
                    { new Guid("e24303f7-293e-467b-b236-13e50f3d90d2"), new DateTime(1995, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5364), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 1, 0, 0, 0)), "customer4@example.com", "Customer 4", "John Doe", "1234567890" },
                    { new Guid("ef73f0aa-8055-4314-9969-7f31c1845950"), new DateTime(1972, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5329), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, 1, 0, 0, 0)), "customer1@example.com", "Customer 1", "John Doe", "1234567890" },
                    { new Guid("f129c122-d315-473c-b641-370bc022b031"), new DateTime(1964, 5, 27, 23, 19, 13, 596, DateTimeKind.Local).AddTicks(5374), "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 1, 0, 0, 0)), "customer5@example.com", "Customer 5", "John Doe", "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateModified", "Description", "InventoryId", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2023, 5, 27, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6109), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Water in sachets", null, null, "pure water" },
                    { 2, null, new DateTimeOffset(new DateTime(2023, 5, 27, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6116), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Water in bottle", null, null, "bottle water" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "DateModified", "IsActive", "ModifiedBy", "TotalCost" },
                values: new object[,]
                {
                    { 1, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 7, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6382), new TimeSpan(0, 1, 0, 0, 0)), new Guid("ef73f0aa-8055-4314-9969-7f31c1845950"), new DateTimeOffset(new DateTime(2023, 4, 30, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6378), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 89549m },
                    { 4, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 17, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6453), new TimeSpan(0, 1, 0, 0, 0)), new Guid("ef73f0aa-8055-4314-9969-7f31c1845950"), new DateTimeOffset(new DateTime(2023, 5, 21, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 56514m },
                    { 7, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 10, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 1, 0, 0, 0)), new Guid("11af2960-8a50-4979-a9c3-b32bc68eba38"), new DateTimeOffset(new DateTime(2023, 5, 26, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 148860m },
                    { 10, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6508), new TimeSpan(0, 1, 0, 0, 0)), new Guid("11af2960-8a50-4979-a9c3-b32bc68eba38"), new DateTimeOffset(new DateTime(2023, 5, 10, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 50180m },
                    { 13, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6534), new TimeSpan(0, 1, 0, 0, 0)), new Guid("a5f3017d-9f83-44fd-9f95-caa571f76abb"), new DateTimeOffset(new DateTime(2023, 4, 30, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6532), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 54373m },
                    { 16, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 1, 0, 0, 0)), new Guid("a5f3017d-9f83-44fd-9f95-caa571f76abb"), new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6559), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 65295m },
                    { 19, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 1, 0, 0, 0)), new Guid("e24303f7-293e-467b-b236-13e50f3d90d2"), new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 97408m },
                    { 22, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 1, 0, 0, 0)), new Guid("e24303f7-293e-467b-b236-13e50f3d90d2"), new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6609), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 38324m },
                    { 25, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6637), new TimeSpan(0, 1, 0, 0, 0)), new Guid("f129c122-d315-473c-b641-370bc022b031"), new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 60952m },
                    { 28, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6714), new TimeSpan(0, 1, 0, 0, 0)), new Guid("f129c122-d315-473c-b641-370bc022b031"), new DateTimeOffset(new DateTime(2023, 5, 10, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6711), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 228450m },
                    { 31, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 1, 0, 0, 0)), new Guid("bbd4474e-7adc-4fbb-ba9e-428c51d88531"), new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 37024m },
                    { 34, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 1, 0, 0, 0)), new Guid("bbd4474e-7adc-4fbb-ba9e-428c51d88531"), new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6762), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 50308m },
                    { 37, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 1, 0, 0, 0)), new Guid("20f09330-8204-4e3a-b343-fd0d6a3ccfa7"), new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6787), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 89644m },
                    { 40, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 12, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 1, 0, 0, 0)), new Guid("20f09330-8204-4e3a-b343-fd0d6a3ccfa7"), new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6812), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 52773m },
                    { 43, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 1, 0, 0, 0)), new Guid("9556a60d-fbbe-4819-937c-832a8b66b6b8"), new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6837), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 112409m },
                    { 46, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6865), new TimeSpan(0, 1, 0, 0, 0)), new Guid("9556a60d-fbbe-4819-937c-832a8b66b6b8"), new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 149563m },
                    { 49, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 1, 0, 0, 0)), new Guid("2cf1decd-666b-4d39-bb31-78e9fdc432ed"), new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6887), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 56883m },
                    { 52, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 1, 0, 0, 0)), new Guid("2cf1decd-666b-4d39-bb31-78e9fdc432ed"), new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6914), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 44406m },
                    { 55, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 8, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, 1, 0, 0, 0)), new Guid("a3c4bd1c-081a-4a99-8ca4-886208a118d3"), new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 49265m },
                    { 58, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 1, 0, 0, 0)), new Guid("a3c4bd1c-081a-4a99-8ca4-886208a118d3"), new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 1, 0, 0, 0)), true, "John Doe", 148401m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomersId", "DateModified", "ModifiedBy", "OrderId", "Price", "ProductId", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 2, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6389), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 1, 403m, 1, null, 31 },
                    { 3, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6404), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 1, 301m, 1, null, 256 },
                    { 5, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6461), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 4, 146m, 2, null, 193 },
                    { 6, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 8, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6467), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 4, 368m, 2, null, 77 },
                    { 8, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 7, 208m, 1, null, 245 },
                    { 9, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 13, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6496), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 7, 356m, 1, null, 275 },
                    { 11, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6516), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6513), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 10, 475m, 2, null, 80 },
                    { 12, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6523), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6521), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 10, 435m, 2, null, 28 },
                    { 14, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 15, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6542), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6540), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 13, 143m, 1, null, 222 },
                    { 15, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6547), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 13, 187m, 1, null, 121 },
                    { 17, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 13, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6567), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 16, 273m, 2, null, 191 },
                    { 18, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 15, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 16, 411m, 2, null, 32 },
                    { 20, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6594), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 19, 420m, 1, null, 66 },
                    { 21, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6601), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6599), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 19, 281m, 1, null, 248 },
                    { 23, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6619), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6616), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 22, 254m, 2, null, 28 },
                    { 24, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6626), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 22, 459m, 2, null, 68 },
                    { 26, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6642), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 25, 312m, 1, null, 88 },
                    { 27, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 12, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 25, 212m, 1, null, 158 },
                    { 29, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 28, 467m, 2, null, 213 },
                    { 30, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 28, 459m, 2, null, 281 },
                    { 32, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 31, 236m, 1, null, 41 },
                    { 33, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 1, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 17, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6752), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 31, 129m, 1, null, 212 },
                    { 35, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 7, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 34, 234m, 2, null, 122 },
                    { 36, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 17, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6777), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 34, 320m, 2, null, 68 },
                    { 38, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 37, 284m, 1, null, 25 },
                    { 39, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 13, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 37, 308m, 1, null, 268 },
                    { 41, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 11, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 40, 161m, 2, null, 69 },
                    { 42, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 11, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 40, 217m, 2, null, 192 },
                    { 44, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 13, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 3, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6845), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 43, 360m, 1, null, 75 },
                    { 45, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 43, 383m, 1, null, 223 },
                    { 47, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6870), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 46, 331m, 2, null, 298 },
                    { 48, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 23, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6880), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 12, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 46, 175m, 2, null, 291 },
                    { 50, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 5, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 14, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6895), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 49, 183m, 1, null, 133 },
                    { 51, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 2, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 6, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6902), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 49, 226m, 1, null, 144 },
                    { 53, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 7, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 52, 256m, 2, null, 42 },
                    { 54, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 16, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 52, 213m, 2, null, 158 },
                    { 56, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 29, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 18, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 55, 215m, 1, null, 37 },
                    { 57, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 9, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 22, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6953), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 55, 270m, 1, null, 153 },
                    { 59, "Jane Smith", new DateTimeOffset(new DateTime(2023, 4, 28, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 58, 437m, 2, null, 269 },
                    { 60, "Jane Smith", new DateTimeOffset(new DateTime(2023, 5, 4, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 1, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2023, 5, 20, 23, 19, 13, 596, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 1, 0, 0, 0)), "John Doe", 58, 241m, 2, null, 128 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerAddressCustomerId",
                table: "Customers",
                column: "CustomerAddressCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor_GuarantorAddressStaffId",
                table: "Guarantor",
                column: "GuarantorAddressStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CustomersId",
                table: "OrderItems",
                column: "CustomersId");

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
                name: "IX_Staffs_StaffAddressStaffId",
                table: "Staffs",
                column: "StaffAddressStaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guarantor");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "GuarantorAddress");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "StaffAddresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");
        }
    }
}
