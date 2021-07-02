using Microsoft.EntityFrameworkCore.Migrations;

namespace RareBookApp.Data.Migrations
{
    public partial class ReconfigureWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Authors_AuthorNumber1",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_AuthorNumber1",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "AuthorNumber1",
                table: "Works");

            migrationBuilder.CreateIndex(
                name: "IX_Works_AuthorNumber",
                table: "Works",
                column: "AuthorNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Authors_AuthorNumber",
                table: "Works",
                column: "AuthorNumber",
                principalTable: "Authors",
                principalColumn: "AuthorNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Authors_AuthorNumber",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_AuthorNumber",
                table: "Works");

            migrationBuilder.AddColumn<int>(
                name: "AuthorNumber1",
                table: "Works",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_AuthorNumber1",
                table: "Works",
                column: "AuthorNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Authors_AuthorNumber1",
                table: "Works",
                column: "AuthorNumber1",
                principalTable: "Authors",
                principalColumn: "AuthorNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
