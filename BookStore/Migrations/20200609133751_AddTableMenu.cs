using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BookStore.Migrations
{
    public partial class AddTableMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "'NULL'"),
                    order = table.Column<int>(type: "int(15)", nullable: true, defaultValue: 0),
                    menuId = table.Column<int>(type: "int(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.id);
                    table.ForeignKey(
                        name: "FK_menu_menu_menuId",
                        column: x => x.menuId,
                        principalTable: "menu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_menu_menuId",
                table: "menu",
                column: "menuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menu");
        }
    }
}
