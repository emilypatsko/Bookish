using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class CreateForeignKeysAttempt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book_BookId",
                table: "Copies");

            migrationBuilder.DropColumn(
                name: "Copy_CopyId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "Member_MemberId",
                table: "Checkouts");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Copies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CopyId",
                table: "Checkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Checkouts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Copies_BookId",
                table: "Copies",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CopyId",
                table: "Checkouts",
                column: "CopyId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_MemberId",
                table: "Checkouts",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Copies_CopyId",
                table: "Checkouts",
                column: "CopyId",
                principalTable: "Copies",
                principalColumn: "CopyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Members_MemberId",
                table: "Checkouts",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Copies_CopyId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Members_MemberId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies");

            migrationBuilder.DropIndex(
                name: "IX_Copies_BookId",
                table: "Copies");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_CopyId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_MemberId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Copies");

            migrationBuilder.DropColumn(
                name: "CopyId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Checkouts");

            migrationBuilder.AddColumn<int>(
                name: "Book_BookId",
                table: "Copies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Copy_CopyId",
                table: "Checkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Member_MemberId",
                table: "Checkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
