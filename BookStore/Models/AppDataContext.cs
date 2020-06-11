using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BookStore.Models
{
    public partial class AppDataContext : DbContext
    {
        private IConfiguration _configuration;
        public AppDataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AppDataContext(DbContextOptions<AppDataContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Categorybook> Categorybook { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = _configuration.GetConnectionString("mysql");
                optionsBuilder.UseMySQL(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(15)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiscountedPrice)
                    .HasColumnName("discountedPrice")
                    .HasDefaultValue(0);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(15)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentID)
                    .HasColumnName("categoryID")
                    .HasColumnType("int(15)");

                entity.HasMany(d => d.childCategories).
                    WithOne(d => d.Parent).
                    HasForeignKey(d => d.ParentID);
            });

            modelBuilder.Entity<Categorybook>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("categorybook");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_CategoryBook_Category");

                entity.Property(e => e.BookId)
                    .HasColumnName("bookId")
                    .HasColumnType("int(15)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(15)");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Categorybook)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_CategoryBook_Book");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Categorybook)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryBook_Category");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(15)")
                    .HasDefaultValue(0);

                entity.Property(e => e.ParentId)
                    .HasColumnName("menuId")
                    .HasColumnType("int(15)");

                entity.HasMany(d => d.ChildMenus).
                    WithOne(d => d.Parent).
                    HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(15)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
