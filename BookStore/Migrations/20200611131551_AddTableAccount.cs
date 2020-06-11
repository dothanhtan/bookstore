using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BookStore.Migrations
{
    public partial class AddTableAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(15)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    email = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    password = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    mobile = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");
        }
    }
}
