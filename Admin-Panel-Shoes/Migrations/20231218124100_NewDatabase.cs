using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLogins",
                columns: table => new
                {
                    AdminLoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdnminLoginUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminLoginPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLogins", x => x.AdminLoginId);
                });

            migrationBuilder.CreateTable(
                name: "Mains",
                columns: table => new
                {
                    MainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mains", x => x.MainId);
                });

            migrationBuilder.CreateTable(
                name: "MainSocialMediaIcons",
                columns: table => new
                {
                    MainSocialMediaIconId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainSocialMediaIconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainSocialMediaIconLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSocialMediaIcons", x => x.MainSocialMediaIconId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLogins");

            migrationBuilder.DropTable(
                name: "Mains");

            migrationBuilder.DropTable(
                name: "MainSocialMediaIcons");
        }
    }
}
