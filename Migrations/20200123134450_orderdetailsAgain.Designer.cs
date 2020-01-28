﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using onlineTShirtShop.OrderContexts;

namespace onlineTShirtShop.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20200123134450_orderdetailsAgain")]
    partial class orderdetailsAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("onlineTShirtShop.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorName = "red"
                        },
                        new
                        {
                            Id = 2,
                            ColorName = "green"
                        },
                        new
                        {
                            Id = 3,
                            ColorName = "blue"
                        },
                        new
                        {
                            Id = 4,
                            ColorName = "black"
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telephone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "tanya.l@l.se",
                            FirstName = "Tanya",
                            LastName = "L",
                            Registered = new DateTime(2019, 12, 4, 14, 44, 50, 13, DateTimeKind.Local).AddTicks(6670),
                            Telephone = 123456789
                        },
                        new
                        {
                            Id = 2,
                            Email = "dima.l@l.se",
                            FirstName = "Dima",
                            LastName = "L",
                            Registered = new DateTime(2020, 1, 13, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(5300),
                            Telephone = 123456789
                        },
                        new
                        {
                            Id = 3,
                            Email = "kolya.l@l.com",
                            FirstName = "Kolya",
                            LastName = "L",
                            Registered = new DateTime(2020, 1, 18, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(5450),
                            Telephone = 123456789
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialName = "cotton"
                        },
                        new
                        {
                            Id = 2,
                            MaterialName = "leather"
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2020, 1, 23, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(8090),
                            CustomerId = 1,
                            Status = "payd"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2020, 1, 23, 11, 44, 50, 24, DateTimeKind.Local).AddTicks(8850),
                            CustomerId = 2,
                            Status = "onpayd"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2020, 1, 21, 14, 44, 50, 24, DateTimeKind.Local).AddTicks(8930),
                            CustomerId = 3,
                            Status = "basket"
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorId = 1,
                            MaterialId = 2,
                            OrderId = 3,
                            ProductId = 1,
                            Quantity = 10,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 2,
                            ColorId = 1,
                            MaterialId = 1,
                            OrderId = 3,
                            ProductId = 1,
                            Quantity = 10,
                            SizeId = 1
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ActualCost")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActualCost = 100m,
                            Details = "Unic cats tshirt, hand made design",
                            ImageUrl = "/images/test1.jpg",
                            Name = "Cats TShirt",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            ActualCost = 90m,
                            Details = "Unic classic tshirt, hand made design",
                            ImageUrl = "/images/test2.jpeg",
                            Name = "Classic TShirt",
                            Price = 90m
                        },
                        new
                        {
                            Id = 3,
                            ActualCost = 80m,
                            Details = "Unic unisex tshirt, hand made design",
                            ImageUrl = "/images/test3.jpeg",
                            Name = "Unisex TShirt",
                            Price = 80m
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SizeName = "XS"
                        },
                        new
                        {
                            Id = 2,
                            SizeName = "S"
                        },
                        new
                        {
                            Id = 3,
                            SizeName = "M"
                        },
                        new
                        {
                            Id = 4,
                            SizeName = "L"
                        },
                        new
                        {
                            Id = 5,
                            SizeName = "XL"
                        },
                        new
                        {
                            Id = 6,
                            SizeName = "XXL"
                        });
                });

            modelBuilder.Entity("onlineTShirtShop.Models.Order", b =>
                {
                    b.HasOne("onlineTShirtShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlineTShirtShop.Models.OrderDetail", b =>
                {
                    b.HasOne("onlineTShirtShop.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onlineTShirtShop.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onlineTShirtShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onlineTShirtShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onlineTShirtShop.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
