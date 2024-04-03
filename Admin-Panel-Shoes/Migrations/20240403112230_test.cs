using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FormLogin",
                columns: table => new
                {
                    FormLoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormLoginUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormLoginPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormLogin", x => x.FormLoginId);
                });

            migrationBuilder.CreateTable(
                name: "Mains",
                columns: table => new
                {
                    MainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainBackgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainSocialMediaIconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainSocialMediaIconLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mains", x => x.MainId);
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
                    ProductsStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsEnumerable", x => x.ProductsId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServicesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AdminLogins");

            migrationBuilder.DropTable(
                name: "CustomersEnumerable");

            migrationBuilder.DropTable(
                name: "FormLogin");

            migrationBuilder.DropTable(
                name: "Mains");

            migrationBuilder.DropTable(
                name: "ProductsEnumerable");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
