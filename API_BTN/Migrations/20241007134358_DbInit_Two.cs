using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_BTN.Migrations
{
    /// <inheritdoc />
    public partial class DbInit_Two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "urlCategory",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "urlCategory",
                table: "Categories");
        }
    }
}
