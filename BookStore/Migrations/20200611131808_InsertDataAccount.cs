using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InsertDataAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("account", new string[] { "id", "name", "email", "password", "mobile" }, new object[,]
            {
                {1, "Thanh Tan", "thanhtan@gmail.com", "123456", "0123456789" },
                {2, "Thanh Tung", "thanhtung@gmail.com", "123456", "0123456789" },
                {3, "Kim Lien", "kimlien@gmail.com", "123456", "0123456789" },
                {4, "Kim Anh", "kimanh@gmail.com", "123456", "0123456789" },
                {5, "Thanh Tu", "thanhtu@gmail.com", "123456", "0123456789" },
                {6, "Thanh Tuan", "thanhtuan@gmail.com", "123456", "0123456789" }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
