using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TWMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemodellingModels : Migration
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
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ProductionCost = table.Column<decimal>(type: "money", nullable: false),
                    DateProduced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RetailPricePerUnit = table.Column<decimal>(type: "money", nullable: false),
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
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_PostalCode = table.Column<int>(type: "int", nullable: false),
                    State_Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                columns: new[] { "CustomerId", "AreaLocality", "BuildingNumber", "City", "CreatedBy", "CreatedDate", "DateModified", "Landmark", "ModifiedBy", "State_Province", "StreetName", "Zip_PostalCode" },
                values: new object[,]
                {
                    { new Guid("07a42c43-a640-4b6a-9aa5-c2970b5ec4fd"), "Area 10", 92, "City 10", "Jane Smith", new DateTime(2023, 5, 18, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 5, 9, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4288), "Landmark 10", "John Doe", "State 10", "Street 10", 78314 },
                    { new Guid("49c5f019-bae1-461e-a6a3-1675fa8bc898"), "Area 6", 34, "City 6", "Jane Smith", new DateTime(2023, 4, 23, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 5, 6, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4254), "Landmark 6", "John Doe", "State 6", "Street 6", 44136 },
                    { new Guid("6046297b-4c1a-4a1b-8d79-ed56bec310d3"), "Area 9", 98, "City 9", "Jane Smith", new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 4, 26, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4278), "Landmark 9", "John Doe", "State 9", "Street 9", 38118 },
                    { new Guid("6426d8f9-9848-4ca9-a30c-0894beb5f1e6"), "Area 4", 83, "City 4", "Jane Smith", new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 5, 2, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4192), "Landmark 4", "John Doe", "State 4", "Street 4", 10549 },
                    { new Guid("b645a87f-8364-4a1c-9205-fe96071357e0"), "Area 2", 2, "City 2", "Jane Smith", new DateTime(2023, 5, 14, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 5, 2, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4174), "Landmark 2", "John Doe", "State 2", "Street 2", 92512 },
                    { new Guid("bc694777-bf5c-4eca-a2ef-bd7296249927"), "Area 7", 66, "City 7", "Jane Smith", new DateTime(2023, 4, 28, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4262), "Landmark 7", "John Doe", "State 7", "Street 7", 69084 },
                    { new Guid("c6597240-6964-462e-ab15-fc2d88e6fca6"), "Area 8", 8, "City 8", "Jane Smith", new DateTime(2023, 4, 27, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 5, 14, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4270), "Landmark 8", "John Doe", "State 8", "Street 8", 43503 },
                    { new Guid("cab6f8d0-19e8-4859-a852-d589290bd217"), "Area 1", 82, "City 1", "Jane Smith", new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 5, 1, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4157), "Landmark 1", "John Doe", "State 1", "Street 1", 44259 },
                    { new Guid("e6be5629-04e9-4c87-aefd-de72b5e4347d"), "Area 3", 85, "City 3", "Jane Smith", new DateTime(2023, 5, 21, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 5, 7, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4183), "Landmark 3", "John Doe", "State 3", "Street 3", 44845 },
                    { new Guid("fd833381-c084-4e20-9e26-a260d259bea6"), "Area 5", 72, "City 5", "Jane Smith", new DateTime(2023, 4, 26, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 5, 10, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(4243), "Landmark 5", "John Doe", "State 5", "Street 5", 67677 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthday", "CreatedBy", "CreatedDate", "CustomerAddressCustomerId", "DateModified", "EmailAddress", "FullName", "ModifiedBy", "PhoneNo" },
                values: new object[,]
                {
                    { new Guid("07a42c43-a640-4b6a-9aa5-c2970b5ec4fd"), new DateTime(2004, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3884), "Jane Smith", new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3879), null, new DateTime(2023, 5, 8, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3877), "customer10@example.com", "Customer 10", "John Doe", "1234567890" },
                    { new Guid("49c5f019-bae1-461e-a6a3-1675fa8bc898"), new DateTime(1981, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3836), "Jane Smith", new DateTime(2023, 5, 7, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3834), null, new DateTime(2023, 5, 7, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3831), "customer6@example.com", "Customer 6", "John Doe", "1234567890" },
                    { new Guid("6046297b-4c1a-4a1b-8d79-ed56bec310d3"), new DateTime(1964, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3870), "Jane Smith", new DateTime(2023, 5, 3, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3868), null, new DateTime(2023, 4, 23, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3865), "customer9@example.com", "Customer 9", "John Doe", "1234567890" },
                    { new Guid("6426d8f9-9848-4ca9-a30c-0894beb5f1e6"), new DateTime(1997, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3800), "Jane Smith", new DateTime(2023, 5, 9, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3798), null, new DateTime(2023, 5, 11, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3796), "customer4@example.com", "Customer 4", "John Doe", "1234567890" },
                    { new Guid("b645a87f-8364-4a1c-9205-fe96071357e0"), new DateTime(2001, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3779), "Jane Smith", new DateTime(2023, 4, 30, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3776), null, new DateTime(2023, 4, 25, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3774), "customer2@example.com", "Customer 2", "John Doe", "1234567890" },
                    { new Guid("bc694777-bf5c-4eca-a2ef-bd7296249927"), new DateTime(1990, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3847), "Jane Smith", new DateTime(2023, 5, 16, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3845), null, new DateTime(2023, 5, 14, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3842), "customer7@example.com", "Customer 7", "John Doe", "1234567890" },
                    { new Guid("c6597240-6964-462e-ab15-fc2d88e6fca6"), new DateTime(1965, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3859), "Jane Smith", new DateTime(2023, 4, 28, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3855), null, new DateTime(2023, 5, 4, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3853), "customer8@example.com", "Customer 8", "John Doe", "1234567890" },
                    { new Guid("cab6f8d0-19e8-4859-a852-d589290bd217"), new DateTime(1992, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3759), "Jane Smith", new DateTime(2023, 4, 28, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3739), null, new DateTime(2023, 5, 1, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3728), "customer1@example.com", "Customer 1", "John Doe", "1234567890" },
                    { new Guid("e6be5629-04e9-4c87-aefd-de72b5e4347d"), new DateTime(1999, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3790), "Jane Smith", new DateTime(2023, 4, 25, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3788), null, new DateTime(2023, 4, 28, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3786), "customer3@example.com", "Customer 3", "John Doe", "1234567890" },
                    { new Guid("fd833381-c084-4e20-9e26-a260d259bea6"), new DateTime(1972, 5, 22, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3813), "Jane Smith", new DateTime(2023, 5, 5, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3811), null, new DateTime(2023, 5, 9, 17, 35, 35, 496, DateTimeKind.Local).AddTicks(3808), "customer5@example.com", "Customer 5", "John Doe", "1234567890" }
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
