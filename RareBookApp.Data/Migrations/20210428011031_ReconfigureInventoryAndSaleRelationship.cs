using Microsoft.EntityFrameworkCore.Migrations;

namespace RareBookApp.Data.Migrations
{
    public partial class ReconfigureInventoryAndSaleRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "SaleID",
                table: "Inventory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory",
                column: "SaleID",
                principalTable: "Sales",
                principalColumn: "SaleID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "SaleID",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory",
                column: "SaleID",
                principalTable: "Sales",
                principalColumn: "SaleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
