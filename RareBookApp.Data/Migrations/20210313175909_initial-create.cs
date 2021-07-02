using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RareBookApp.Data.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Authors",
            //    columns: table => new
            //    {
            //        AuthorNumber = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AuthorFirstLastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Authors", x => x.AuthorNumber);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ConditionCodes",
            //    columns: table => new
            //    {
            //        ConditionCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ConditionDescription = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ConditionCodes", x => x.ConditionCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        CustomerNumber = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        City = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ZipCode = table.Column<int>(type: "int", nullable: false),
            //        ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customers", x => x.CustomerNumber);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Publishers",
            //    columns: table => new
            //    {
            //        PublisherID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Publishers", x => x.PublisherID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Works",
            //    columns: table => new
            //    {
            //        WorkNumber = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AuthorNumber = table.Column<int>(type: "int", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AuthorNumber1 = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Works", x => x.WorkNumber);
            //        table.ForeignKey(
            //            name: "FK_Works_Authors_AuthorNumber1",
            //            column: x => x.AuthorNumber1,
            //            principalTable: "Authors",
            //            principalColumn: "AuthorNumber",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sales",
            //    columns: table => new
            //    {
            //        SaleID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CustomerNumber = table.Column<int>(type: "int", nullable: false),
            //        SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        SalesTotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        CreditCardNumber = table.Column<long>(type: "bigint", nullable: false),
            //        ExpirationMonth = table.Column<int>(type: "int", nullable: false),
            //        ExpirationDate = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sales", x => x.SaleID);
            //        table.ForeignKey(
            //            name: "FK_Sales_Customers_CustomerNumber",
            //            column: x => x.CustomerNumber,
            //            principalTable: "Customers",
            //            principalColumn: "CustomerNumber",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    columns: table => new
            //    {
            //        ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        WorkNumber = table.Column<int>(type: "int", nullable: false),
            //        PublisherID = table.Column<int>(type: "int", nullable: false),
            //        Edition = table.Column<int>(type: "int", nullable: false),
            //        Board = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CopyrightYear = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Books", x => x.ISBN);
            //        table.ForeignKey(
            //            name: "FK_Books_Publishers_PublisherID",
            //            column: x => x.PublisherID,
            //            principalTable: "Publishers",
            //            principalColumn: "PublisherID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Books_Works_WorkNumber",
            //            column: x => x.WorkNumber,
            //            principalTable: "Works",
            //            principalColumn: "WorkNumber",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Inventory",
            //    columns: table => new
            //    {
            //        InventoryID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ISBN = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        ConditionCode = table.Column<int>(type: "int", nullable: false),
            //        DateAcquired = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        AskingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        SaleID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Inventory", x => x.InventoryID);
            //        table.ForeignKey(
            //            name: "FK_Inventory_Books_ISBN",
            //            column: x => x.ISBN,
            //            principalTable: "Books",
            //            principalColumn: "ISBN",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Inventory_ConditionCodes_ConditionCode",
            //            column: x => x.ConditionCode,
            //            principalTable: "ConditionCodes",
            //            principalColumn: "ConditionCode",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Inventory_Sales_SaleID",
            //            column: x => x.SaleID,
            //            principalTable: "Sales",
            //            principalColumn: "SaleID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Books_PublisherID",
            //    table: "Books",
            //    column: "PublisherID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Books_WorkNumber",
            //    table: "Books",
            //    column: "WorkNumber");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Inventory_ConditionCode",
            //    table: "Inventory",
            //    column: "ConditionCode");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Inventory_ISBN",
            //    table: "Inventory",
            //    column: "ISBN");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Inventory_SaleID",
            //    table: "Inventory",
            //    column: "SaleID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sales_CustomerNumber",
            //    table: "Sales",
            //    column: "CustomerNumber");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Works_AuthorNumber1",
            //    table: "Works",
            //    column: "AuthorNumber1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "ConditionCodes");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
