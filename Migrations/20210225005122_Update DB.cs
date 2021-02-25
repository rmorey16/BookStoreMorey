using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreMorey.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Classification");

            migrationBuilder.AddColumn<string>(
                name: "AuthorFName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AuthorLName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumPages",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorFName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthorLName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NumPages",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Classification",
                table: "Books",
                newName: "Author");
        }
    }
}
