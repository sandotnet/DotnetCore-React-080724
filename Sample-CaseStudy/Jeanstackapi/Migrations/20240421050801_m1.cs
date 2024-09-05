using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeanstackapi.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_orders_OrderId",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "orders",
                newName: "totalAmount");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "orders",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "carts",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_carts_OrderId",
                table: "carts",
                newName: "IX_carts_Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_orders_Orderid",
                table: "carts",
                column: "Orderid",
                principalTable: "orders",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_orders_Orderid",
                table: "carts");

            migrationBuilder.RenameColumn(
                name: "totalAmount",
                table: "orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "carts",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_carts_Orderid",
                table: "carts",
                newName: "IX_carts_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_orders_OrderId",
                table: "carts",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");
        }
    }
}
