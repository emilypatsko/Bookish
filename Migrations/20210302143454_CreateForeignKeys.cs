using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class CreateForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Copies",
                newName: "Book_BookId");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Checkouts",
                newName: "Member_MemberId");

            migrationBuilder.RenameColumn(
                name: "CopyId",
                table: "Checkouts",
                newName: "Copy_CopyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Book_BookId",
                table: "Copies",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "Member_MemberId",
                table: "Checkouts",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "Copy_CopyId",
                table: "Checkouts",
                newName: "CopyId");
        }
    }
}
