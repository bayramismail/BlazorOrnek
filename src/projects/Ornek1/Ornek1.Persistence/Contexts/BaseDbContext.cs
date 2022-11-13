using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ornek1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public BaseDbContext(DbContextOptions<BaseDbContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }
        protected BaseDbContext(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnectionString"))
                    .EnableSensitiveDataLogging());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>(a =>
            {
                a.ToTable("Products").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.CategoryId).HasColumnName("CategoryId");
                a.Property(p => p.Name).HasColumnName("Name").HasMaxLength(100);
                a.Property(p => p.Description).HasColumnName("Description");
                a.Property(p => p.Price).HasColumnName("Price");
                a.Property(p => p.Discount).HasColumnName("Discount");
                a.HasOne(p => p.Category);
                a.HasMany(p => p.ProductImages);
            });

            Product[] productEntityModels = {
                new (
                id : 1,
                categoryId : 1,
                name : "Asus ROG Strix G17 G713RS-KH010 ",
                description : "Ryzen 9 6900HX 16GB RAM 1TB SSD 8GB RTX3080 17.3 FHD 360Hz",
                discount : 111,
                price:15000
                ),new(
                id : 2,
                categoryId : 1,
                name : "MSI RAIDER GE77HX 12UGS-039TR i7 12800HX",
                description : "32GB DDR5 2TB SSD RTX3070Ti 8GB 17,3 Windows 11 Home Gaming Notebook",
                discount : 111,
                price : decimal.Parse("78.087")
                ) };
            modelBuilder.Entity<Product>().HasData(productEntityModels);

            modelBuilder.Entity<Category>(a =>
            {
                a.ToTable("Categories").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name").HasMaxLength(100);
            });
            Category[] categoryEntityModels = { new(id: 1, "Laptop") };
            modelBuilder.Entity<Category>().HasData(categoryEntityModels);

            modelBuilder.Entity<ProductImage>(a =>
            {
                a.ToTable("ProductImages").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.ProductId).HasColumnName("ProductId");
                a.Property(p => p.ImageUrl).HasColumnName("ImageUrl").HasMaxLength(100);
                a.HasOne(p => p.Product);
            });
            ProductImage[] productImageEntityModels = {
                new(id: 1,1, "https://m.media-amazon.com/images/I/71lixkqPdxL._AC_SL1500_.jpg"),
                new(id: 2, 1, "https://m.media-amazon.com/images/I/71II0q7ZakL._AC_SL1500_.jpg"),
                new(id: 3, 1, "https://m.media-amazon.com/images/I/61SC2adpsuL._AC_SL1500_.jpg"),
                new(id: 4, 1, "https://m.media-amazon.com/images/I/51knE-Dz7+L._AC_SL1500_.jpg"),
                new(id: 5, 2, "https://m.media-amazon.com/images/I/61uxDTnehrL._AC_SL1500_.jpg"),
                new(id: 6, 2, "https://m.media-amazon.com/images/I/51mYZdJe4SL._AC_SL1000_.jpg"),
                new(id: 7, 2, "https://m.media-amazon.com/images/I/61aEOx3FA1L._AC_SL1500_.jpg"),
                new(id: 8, 2, "https://m.media-amazon.com/images/I/51fSPNd7+7L._AC_SL1500_.jpg")
            };
            modelBuilder.Entity<ProductImage>().HasData(productImageEntityModels);
        }
    }
}
