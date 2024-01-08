using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class CategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductsCategoryName",
                table: "ProductsEnumerable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductsCategoryName",
                table: "ProductsEnumerable");
        }
    }
}
