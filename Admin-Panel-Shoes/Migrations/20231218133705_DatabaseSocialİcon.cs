using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSocialİcon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainSocialMediaIconLink",
                table: "MainSocialMediaIcons");

            migrationBuilder.DropColumn(
                name: "MainSocialMediaIconName",
                table: "MainSocialMediaIcons");

            migrationBuilder.AddColumn<string>(
                name: "MainSocialMediaIconLink",
                table: "Mains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainSocialMediaIconName",
                table: "Mains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMainImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersEnumerable",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersEnumerable", x => x.CustomersId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsEnumerable",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcuctsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsPrice = table.Column<int>(type: "int", nullable: false),
                    ProductsStar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsEnumerable", x => x.ProductsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "CustomersEnumerable");

            migrationBuilder.DropTable(
                name: "ProductsEnumerable");

            migrationBuilder.DropColumn(
                name: "MainSocialMediaIconLink",
                table: "Mains");

            migrationBuilder.DropColumn(
                name: "MainSocialMediaIconName",
                table: "Mains");

            migrationBuilder.AddColumn<string>(
                name: "MainSocialMediaIconLink",
                table: "MainSocialMediaIcons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainSocialMediaIconName",
                table: "MainSocialMediaIcons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
