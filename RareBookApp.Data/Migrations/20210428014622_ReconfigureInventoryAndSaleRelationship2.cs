using Microsoft.EntityFrameworkCore.Migrations;

namespace RareBookApp.Data.Migrations
{
    public partial class ReconfigureInventoryAndSaleRelationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_SaleID",
                table: "Inventory");

            migrationBuilder.AddColumn<int>(
                name: "VolumeInventoryID",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VolumeInventoryID",
                table: "Sales",
                column: "VolumeInventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Inventory_VolumeInventoryID",
                table: "Sales",
                column: "VolumeInventoryID",
                principalTable: "Inventory",
                principalColumn: "InventoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Inventory_VolumeInventoryID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_VolumeInventoryID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "VolumeInventoryID",
                table: "Sales");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_SaleID",
                table: "Inventory",
                column: "SaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Sales_SaleID",
                table: "Inventory",
                column: "SaleID",
                principalTable: "Sales",
                principalColumn: "SaleID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
