﻿// <auto-generated />
using Furnits.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Furnits.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Furnits.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ManagerName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Furnits.Models.Products.Assortment.Divan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BackDegree")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsArticle")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductsArticle")
                        .IsUnique();

                    b.ToTable("Divans");
                });

            modelBuilder.Entity("Furnits.Models.Products.Product", b =>
                {
                    b.Property<int>("Article")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Article");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsArticle")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "ProductsArticle");

                    b.HasIndex("ProductsArticle");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Furnits.Models.Products.Assortment.Divan", b =>
                {
                    b.HasOne("Furnits.Models.Products.Product", "Product")
                        .WithOne("Divan")
                        .HasForeignKey("Furnits.Models.Products.Assortment.Divan", "ProductsArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Furnits.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Furnits.Models.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Furnits.Models.Products.Product", b =>
                {
                    b.Navigation("Divan");
                });
#pragma warning restore 612, 618
        }
    }
}