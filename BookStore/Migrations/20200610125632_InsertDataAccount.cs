﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InsertDataAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("account", new string[] { "id", "name", "email", "password" }, new object[,]
            {
                {1, "Đỗ Thanh Tân", "thanhtan@gmail.com", "123456" },
                {2, "Đỗ Thanh Tùng", "thanhtung@gmail.com", "123456" },
                {3, "Đỗ Thanh Tú", "thanhtu@gmail.com", "123456" },
                {4, "Đỗ Thanh Tuấn", "thanhtuan@gmail.com", "123456" }
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}