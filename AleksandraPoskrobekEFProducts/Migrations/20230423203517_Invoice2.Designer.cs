﻿// <auto-generated />
using AleksandraPoskrobekEFProducts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AleksandraPoskrobekEFProducts.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230423203517_Invoice2")]
    partial class Invoice2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("AleksandraPoskrobekEFProducts.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("AleksandraPoskrobekEFProducts.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitsOnStock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("supplierID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductID");

                    b.HasIndex("supplierID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AleksandraPoskrobekEFProducts.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("InvoiceProduct", b =>
                {
                    b.Property<int>("InvoicesInvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoldProductsProductID")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvoicesInvoiceID", "SoldProductsProductID");

                    b.HasIndex("SoldProductsProductID");

                    b.ToTable("InvoiceProduct");
                });

            modelBuilder.Entity("AleksandraPoskrobekEFProducts.Product", b =>
                {
                    b.HasOne("AleksandraPoskrobekEFProducts.Supplier", "Supplier")
                        .WithMany("SupplierProducts")
                        .HasForeignKey("supplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("InvoiceProduct", b =>
                {
                    b.HasOne("AleksandraPoskrobekEFProducts.Invoice", null)
                        .WithMany()
                        .HasForeignKey("InvoicesInvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleksandraPoskrobekEFProducts.Product", null)
                        .WithMany()
                        .HasForeignKey("SoldProductsProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AleksandraPoskrobekEFProducts.Supplier", b =>
                {
                    b.Navigation("SupplierProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
