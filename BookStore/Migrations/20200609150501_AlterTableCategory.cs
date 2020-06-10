using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class AlterTableCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "category",
                type: "int(15)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_category_categoryID",
                table: "category",
                column: "categoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_category_category_categoryID",
                table: "category",
                column: "categoryID",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_category_categoryID",
                table: "category");

            migrationBuilder.DropIndex(
                name: "IX_category_categoryID",
                table: "category");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "category");
        }
    }
}
