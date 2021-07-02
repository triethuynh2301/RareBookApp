using Microsoft.EntityFrameworkCore.Migrations;

namespace RareBookApp.Data.Migrations
{
    public partial class ModifyColumnNameSaleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Sales",
                newName: "ExpirationYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationYear",
                table: "Sales",
                newName: "ExpirationDate");
        }
    }
}
