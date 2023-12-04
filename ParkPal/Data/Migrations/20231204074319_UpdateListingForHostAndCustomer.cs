using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkPal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateListingForHostAndCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Listings",
                newName: "HostId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Listings",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Listings");

            migrationBuilder.RenameColumn(
                name: "HostId",
                table: "Listings",
                newName: "UserId");
        }
    }
}
