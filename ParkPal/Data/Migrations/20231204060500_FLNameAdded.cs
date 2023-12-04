using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkPal.Migrations
{
    /// <inheritdoc />
    public partial class FLNameAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "Lname");

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Lname",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
