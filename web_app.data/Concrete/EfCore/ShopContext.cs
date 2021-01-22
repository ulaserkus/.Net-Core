using System;
using Microsoft.EntityFrameworkCore;
using web_app.entity;

namespace web_app.data.Concrete.EfCore
{
    public class ShopContext:DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ShopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new { c.CategoryId,c.ProductId});

        }
    }
}
