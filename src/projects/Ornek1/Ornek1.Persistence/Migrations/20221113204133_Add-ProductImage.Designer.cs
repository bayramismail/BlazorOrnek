﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Ornek1.Persistence.Contexts;

#nullable disable

namespace Ornek1.Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20221113204133_Add-ProductImage")]
    partial class AddProductImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ornek1.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Laptop"
                        });
                });

            modelBuilder.Entity("Ornek1.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric")
                        .HasColumnName("Discount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Ryzen 9 6900HX 16GB RAM 1TB SSD 8GB RTX3080 17.3 FHD 360Hz",
                            Discount = 111m,
                            Name = "Asus ROG Strix G17 G713RS-KH010 ",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "32GB DDR5 2TB SSD RTX3070Ti 8GB 17,3 Windows 11 Home Gaming Notebook",
                            Discount = 111m,
                            Name = "MSI RAIDER GE77HX 12UGS-039TR i7 12800HX",
                            Price = 78087m
                        });
                });

            modelBuilder.Entity("Ornek1.Domain.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("ImageUrl");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71lixkqPdxL._AC_SL1500_.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://m.media-amazon.com/images/I/71II0q7ZakL._AC_SL1500_.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://m.media-amazon.com/images/I/61SC2adpsuL._AC_SL1500_.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://m.media-amazon.com/images/I/51knE-Dz7+L._AC_SL1500_.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://m.media-amazon.com/images/I/61uxDTnehrL._AC_SL1500_.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://m.media-amazon.com/images/I/51mYZdJe4SL._AC_SL1000_.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "https://m.media-amazon.com/images/I/61aEOx3FA1L._AC_SL1500_.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "https://m.media-amazon.com/images/I/51fSPNd7+7L._AC_SL1500_.jpg",
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("Ornek1.Domain.Entities.Product", b =>
                {
                    b.HasOne("Ornek1.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ornek1.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("Ornek1.Domain.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ornek1.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
