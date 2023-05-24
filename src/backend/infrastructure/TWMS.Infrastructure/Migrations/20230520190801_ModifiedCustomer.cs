using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TWMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAddresses_CustomerAddressId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0352fcda-393a-48a0-83a0-9178520f6af6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("31812621-52da-4a8d-b4b8-4e7ea885c651"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("393f3cc7-d21c-4c7f-996e-98d0c8d5e8b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651ce050-0a72-4c98-8516-a480046f7955"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("68595538-779b-46b0-bd58-2f0c8027bfa0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8adb2040-5ab8-47b9-9a76-a4d58ec90ce3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a4f21388-e64b-4263-9c57-ba4e8367dab7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b238ee47-c577-421e-b4d5-d468a018c572"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e75795ef-cbe8-4a84-8de1-9e493281bab8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff676444-0d3c-4eea-8d27-c97cea12ee17"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 80, new DateTime(2023, 5, 13, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 5, 7, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2949), 59229 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 75, new DateTime(2023, 5, 2, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 4, 24, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2978), 22547 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 27, new DateTime(2023, 5, 5, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 5, 9, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2988), 58267 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 83, new DateTime(2023, 4, 22, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 4, 23, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2998), 89971 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 75, new DateTime(2023, 5, 2, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 4, 22, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3008), 41039 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 77, new DateTime(2023, 4, 26, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 5, 10, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3065), 30035 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 73, new DateTime(2023, 5, 6, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 5, 19, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3075), 25858 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 63, new DateTime(2023, 5, 16, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 5, 7, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3085), 87300 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 76, new DateTime(2023, 4, 29, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 5, 18, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3095), 55548 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 59, new DateTime(2023, 5, 3, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 4, 26, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(3106), 50636 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthday", "CreatedBy", "CreatedDate", "CustomerAddressId", "DateModified", "EmailAddress", "FullName", "ModifiedBy", "PhoneNo" },
                values: new object[,]
                {
                    { new Guid("0b312454-7a49-49c0-b198-819ad081cebc"), new DateTime(1967, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2654), "Jane Smith", new DateTime(2023, 4, 27, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2652), 6, new DateTime(2023, 5, 9, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2651), "customer6@example.com", "Customer 6", "John Doe", "1234567890" },
                    { new Guid("23f9048e-ed49-4f9e-acfa-ca5add7ae92e"), new DateTime(1988, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2593), "Jane Smith", new DateTime(2023, 4, 21, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2568), 1, new DateTime(2023, 4, 25, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2556), "customer1@example.com", "Customer 1", "John Doe", "1234567890" },
                    { new Guid("44185cd0-77e9-4e9c-b810-fb44ca399b4c"), new DateTime(1965, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2622), "Jane Smith", new DateTime(2023, 5, 11, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2620), 3, new DateTime(2023, 4, 23, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2619), "customer3@example.com", "Customer 3", "John Doe", "1234567890" },
                    { new Guid("94536a66-037c-47a2-b3fd-e96061bef0a8"), new DateTime(1998, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2629), "Jane Smith", new DateTime(2023, 4, 26, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2627), 4, new DateTime(2023, 5, 15, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2626), "customer4@example.com", "Customer 4", "John Doe", "1234567890" },
                    { new Guid("a0c509ec-c504-4738-b8c6-df1a5be07bef"), new DateTime(1998, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2687), "Jane Smith", new DateTime(2023, 5, 9, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2684), 10, new DateTime(2023, 4, 23, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2683), "customer10@example.com", "Customer 10", "John Doe", "1234567890" },
                    { new Guid("b235cdec-2ca5-4001-a16a-fe26a531977b"), new DateTime(1985, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2614), "Jane Smith", new DateTime(2023, 5, 3, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2611), 2, new DateTime(2023, 5, 14, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2610), "customer2@example.com", "Customer 2", "John Doe", "1234567890" },
                    { new Guid("b2888f19-76d5-4977-a1ea-3fc6230ec401"), new DateTime(1994, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2663), "Jane Smith", new DateTime(2023, 5, 13, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2660), 7, new DateTime(2023, 5, 12, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2658), "customer7@example.com", "Customer 7", "John Doe", "1234567890" },
                    { new Guid("e68ecc40-835d-4e73-8b6f-8aa62843c406"), new DateTime(1969, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2637), "Jane Smith", new DateTime(2023, 4, 23, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2635), 5, new DateTime(2023, 4, 25, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2634), "customer5@example.com", "Customer 5", "John Doe", "1234567890" },
                    { new Guid("fbed4de2-a805-47a5-9b7e-b475a8cc4949"), new DateTime(2001, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2678), "Jane Smith", new DateTime(2023, 5, 8, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2676), 9, new DateTime(2023, 5, 5, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2675), "customer9@example.com", "Customer 9", "John Doe", "1234567890" },
                    { new Guid("fea1259a-f68f-42f5-8211-0ab0e6dc6fe4"), new DateTime(2002, 5, 20, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2671), "Jane Smith", new DateTime(2023, 4, 28, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2668), 8, new DateTime(2023, 5, 19, 20, 8, 0, 945, DateTimeKind.Local).AddTicks(2667), "customer8@example.com", "Customer 8", "John Doe", "1234567890" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CustomersId",
                table: "OrderItems",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAddresses_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId",
                principalTable: "CustomerAddresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Customers_CustomersId",
                table: "OrderItems",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAddresses_CustomerAddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Customers_CustomersId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CustomersId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0b312454-7a49-49c0-b198-819ad081cebc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("23f9048e-ed49-4f9e-acfa-ca5add7ae92e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("44185cd0-77e9-4e9c-b810-fb44ca399b4c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("94536a66-037c-47a2-b3fd-e96061bef0a8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a0c509ec-c504-4738-b8c6-df1a5be07bef"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b235cdec-2ca5-4001-a16a-fe26a531977b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b2888f19-76d5-4977-a1ea-3fc6230ec401"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e68ecc40-835d-4e73-8b6f-8aa62843c406"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fbed4de2-a805-47a5-9b7e-b475a8cc4949"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fea1259a-f68f-42f5-8211-0ab0e6dc6fe4"));

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 99, new DateTime(2023, 5, 5, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 4, 25, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3085), 57185 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 29, new DateTime(2023, 5, 4, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 4, 20, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3106), 15239 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 66, new DateTime(2023, 4, 20, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 5, 8, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3117), 22578 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 45, new DateTime(2023, 5, 13, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 5, 14, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3129), 83692 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 70, new DateTime(2023, 5, 15, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 4, 30, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3141), 17667 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 48, new DateTime(2023, 4, 23, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 4, 24, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3154), 22509 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 88, new DateTime(2023, 5, 1, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 5, 8, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3164), 68152 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 10, new DateTime(2023, 4, 21, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 5, 11, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3173), 55500 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 44, new DateTime(2023, 4, 24, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 4, 21, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3183), 40656 });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNumber", "CreatedDate", "DateModified", "Zip_PostalCode" },
                values: new object[] { 16, new DateTime(2023, 5, 16, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 5, 12, 21, 49, 44, 508, DateTimeKind.Local).AddTicks(3194), 47143 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAddresses_CustomerAddressId",
                table: "Customers",
                column: "CustomerAddressId",
                principalTable: "CustomerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
