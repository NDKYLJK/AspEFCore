using Microsoft.EntityFrameworkCore.Migrations;

namespace AspEFCore.Data.Migrations
{
    public partial class AddManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Passwoed",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Passwoed",
                table: "Admins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwoed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Passwoed",
                table: "Admins");
        }
    }
}
