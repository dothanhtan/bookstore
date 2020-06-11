using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InsertDataCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("category", new string[] { "id", "title", "categoryID" }, new object[,]
            {
                {1, "Accessories", null },
                {2, "Arts & Photography", null },
                {3, "Biographies", null },
                {4, "Business & Money", null },
                {5, "Calendars", null },
                {6, "Children's Books", null },
                {7, "Comics", null },
                {8, "Cookbooks", null },
                {9, "Education", null },
                {10, "Indoor Living", null },
                {11, "More Categories", null }, 
                {12, "Shop", 11 },
                {13, "Saws", 11 },
                {14, "Drills", 11 },
                {15, "Sanders", 11 },
            });

            migrationBuilder.InsertData("categorybook", new string[] { "bookId", "categoryId" }, new object[,]
            {
                {1, 1 },
                {2, 2 },
                {3, 3 },
                {4, 4 },
                {5, 5 },
                {6, 6 },
                {7, 7 },
                {8, 8 },
                {9, 9 },
                {10, 10 },
                {11, 11 },
                {12, 2 },
                {13, 3 },
                {14, 3 },
                {15, 4 },
                {16, 4 },
                {17, 4 },
                {19, 5 },
                {20, 5 },
                {21, 5 },
                {22, 5 },
                {23, 6 },
                {24, 6 },
                {25, 6 },
                {26, 6 },
                {27, 6 },
                {28, 7 },
                {29, 7 },
                {30, 7 },
                {31, 7 },
                {32, 7 },
                {33, 7 },
                {34, 8 },
                {35, 8 },
                {36, 8 },
                {37, 8 },
                {38, 8 },
                {39, 8 },
                {40, 8 },
                {41, 9 },
                {42, 9 },
                {43, 9 },
                {44, 9 },
                {45, 9 },
                {46, 9 },
                {47, 9 },
                {48, 9 },
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categorybook");
            migrationBuilder.DeleteData("category", "id", new object[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 11
            });
        }
    }
}
