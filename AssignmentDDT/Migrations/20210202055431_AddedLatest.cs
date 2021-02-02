using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentDDT.Migrations
{
    public partial class AddedLatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersLists",
                table: "UsersLists");

            migrationBuilder.RenameTable(
                name: "UsersLists",
                newName: "UsersList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersList",
                table: "UsersList",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersList",
                table: "UsersList");

            migrationBuilder.RenameTable(
                name: "UsersList",
                newName: "UsersLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersLists",
                table: "UsersLists",
                column: "Id");
        }
    }
}
