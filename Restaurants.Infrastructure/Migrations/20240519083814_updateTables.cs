using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurants.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Strret",
                table: "Restaurants",
                newName: "Address_Street");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Restaurants",
                newName: "Address_Strret");
        }
    }
}
