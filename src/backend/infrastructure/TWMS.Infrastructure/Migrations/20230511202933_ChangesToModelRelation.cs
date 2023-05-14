using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TWMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToModelRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Customers_CustomersId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CustomersId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ReportsTo",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Inventory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportsTo",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomersId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CustomersId",
                table: "OrderItems",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Customers_CustomersId",
                table: "OrderItems",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
