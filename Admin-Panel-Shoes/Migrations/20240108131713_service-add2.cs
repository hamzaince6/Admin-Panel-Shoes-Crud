using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class serviceadd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Services");
        }
    }
}
