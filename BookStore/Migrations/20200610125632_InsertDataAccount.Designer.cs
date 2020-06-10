﻿// <auto-generated />
using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20200610125632_InsertDataAccount")]
    partial class InsertDataAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BookStore.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("account");
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(15)");

                    b.Property<string>("Author")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("author")
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("description")
                        .HasColumnType("varchar(1000)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<float>("DiscountedPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("discountedPrice")
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<float>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("price")
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("title")
                        .HasColumnType("varchar(500)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("book");
                });

            modelBuilder.Entity("BookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(15)");

                    b.Property<int?>("ParentID")
                        .HasColumnName("categoryID")
                        .HasColumnType("int(15)");

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("title")
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("ParentID");

                    b.ToTable("category");
                });

            modelBuilder.Entity("BookStore.Models.Categorybook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnName("bookId")
                        .HasColumnType("int(15)");

                    b.Property<int>("CategoryId")
                        .HasColumnName("categoryId")
                        .HasColumnType("int(15)");

                    b.HasKey("BookId", "CategoryId")
                        .HasName("PRIMARY");

                    b.HasIndex("CategoryId")
                        .HasName("FK_CategoryBook_Category");

                    b.ToTable("categorybook");
                });

            modelBuilder.Entity("BookStore.Models.Menu", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int?>("Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("order")
                        .HasColumnType("int(15)")
                        .HasDefaultValue(0);

                    b.Property<int?>("ParentId")
                        .HasColumnName("menuId")
                        .HasColumnType("int(15)");

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("title")
                        .HasColumnType("varchar(200)")
                        .HasDefaultValueSql("'NULL'")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("BookStore.Models.Category", b =>
                {
                    b.HasOne("BookStore.Models.Category", "Parent")
                        .WithMany("childCategories")
                        .HasForeignKey("ParentID");
                });

            modelBuilder.Entity("BookStore.Models.Categorybook", b =>
                {
                    b.HasOne("BookStore.Models.Book", "Book")
                        .WithMany("Categorybook")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_CategoryBook_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Category", "Category")
                        .WithMany("Categorybook")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_CategoryBook_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Models.Menu", b =>
                {
                    b.HasOne("BookStore.Models.Menu", "Parent")
                        .WithMany("ChildMenus")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
