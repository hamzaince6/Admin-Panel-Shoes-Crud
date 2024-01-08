using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class servicead4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainSocialMediaIcons");

            migrationBuilder.AddColumn<string>(
                name: "MainBackgroundImage",
                table: "Mains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainBackgroundImage",
                table: "Mains");

            migrationBuilder.CreateTable(
                name: "MainSocialMediaIcons",
                columns: table => new
                {
                    MainSocialMediaIconId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSocialMediaIcons", x => x.MainSocialMediaIconId);
                });
        }
    }
}
