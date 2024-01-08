using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin_Panel_Shoes.Migrations
{
    /// <inheritdoc />
    public partial class serviceadd5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormLogin");
        }
    }
}
