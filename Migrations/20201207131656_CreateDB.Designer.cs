﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakersShoesShop.OrderContexts;

namespace SneakersShoesShop.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20201207131656_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("sneakersShoesShop.Models.Color", b =>
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
                            ColorName = "black"
                        },
                        new
                        {
                            Id = 2,
                            ColorName = "green"
                        },
                        new
                        {
                            Id = 3,
                            ColorName = "pink"
                        },
                        new
                        {
                            Id = 4,
                            ColorName = "white"
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Customer", b =>
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
                            Email = "kitty1@gmail.com",
                            FirstName = "Katarzyna",
                            LastName = "Sz",
                            Registered = new DateTime(2020, 10, 18, 14, 16, 55, 726, DateTimeKind.Local).AddTicks(673),
                            Telephone = 123456789
                        },
                        new
                        {
                            Id = 2,
                            Email = "anna@gmail.com",
                            FirstName = "Anna",
                            LastName = "Sz",
                            Registered = new DateTime(2020, 11, 27, 14, 16, 55, 731, DateTimeKind.Local).AddTicks(8010),
                            Telephone = 123456789
                        },
                        new
                        {
                            Id = 3,
                            Email = "piotr90@gmail.com",
                            FirstName = "Piotr",
                            LastName = "Sz",
                            Registered = new DateTime(2020, 12, 2, 14, 16, 55, 731, DateTimeKind.Local).AddTicks(8209),
                            Telephone = 123456789
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Type");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialName = "cotton and syntetic"
                        },
                        new
                        {
                            Id = 2,
                            MaterialName = "leather"
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Order", b =>
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
                            Created = new DateTime(2020, 12, 7, 14, 16, 55, 735, DateTimeKind.Local).AddTicks(5576),
                            CustomerId = 1,
                            Status = "BASKET"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2020, 12, 7, 11, 16, 55, 735, DateTimeKind.Local).AddTicks(6189),
                            CustomerId = 2,
                            Status = "onpaid"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2020, 12, 5, 14, 16, 55, 735, DateTimeKind.Local).AddTicks(6272),
                            CustomerId = 3,
                            Status = "basket"
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.OrderDetail", b =>
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
                });

            modelBuilder.Entity("sneakersShoesShop.Models.OrderRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
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

                    b.ToTable("OrderRows");
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ActualCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaterialId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActualCost = 200m,
                            ColorId = 2,
                            Details = "Hand painted shoes with nice monster",
                            ImageUrl = "/assets/images/shoesMonster.jpg",
                            MaterialId = 1,
                            Name = "Design shoes monster",
                            Price = 200m,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActualCost = 190m,
                            ColorId = 1,
                            Details = "Sentimentaly game, hand painted shoes",
                            ImageUrl = "/assets/images/shoesPac.jpg",
                            MaterialId = 1,
                            Name = "Design shoes Pac-Man",
                            Price = 190m,
                            SizeId = 2
                        },
                        new
                        {
                            Id = 3,
                            ActualCost = 380m,
                            ColorId = 4,
                            Details = "Hand painted shoes, perfect for cats lovers",
                            ImageUrl = "/assets/images/shoesCat.jpg",
                            MaterialId = 1,
                            Name = "Design shoes Cat",
                            Price = 380m,
                            SizeId = 3
                        },
                        new
                        {
                            Id = 4,
                            ActualCost = 200m,
                            ColorId = 4,
                            Details = "Unisex shoes",
                            ImageUrl = "/assets/images/shoesLetherW.jpg",
                            MaterialId = 2,
                            Name = "Lether shoes",
                            Price = 200m,
                            SizeId = 4
                        },
                        new
                        {
                            Id = 5,
                            ActualCost = 280m,
                            ColorId = 2,
                            Details = "Lether shoes in dark green color, perfect for rainy day",
                            ImageUrl = "/assets/images/shoesLetherG.jpg",
                            MaterialId = 2,
                            Name = "Dark leather shoes",
                            Price = 280m,
                            SizeId = 3
                        },
                        new
                        {
                            Id = 6,
                            ActualCost = 480m,
                            ColorId = 3,
                            Details = "Sweat pink shoes for every woman",
                            ImageUrl = "/assets/images/shoesLetherP.jpg",
                            MaterialId = 2,
                            Name = "Pinky pink leather shoes",
                            Price = 480m,
                            SizeId = 3
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Size", b =>
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
                            SizeName = "35"
                        },
                        new
                        {
                            Id = 2,
                            SizeName = "36"
                        },
                        new
                        {
                            Id = 3,
                            SizeName = "37"
                        },
                        new
                        {
                            Id = 4,
                            SizeName = "38"
                        },
                        new
                        {
                            Id = 5,
                            SizeName = "40"
                        },
                        new
                        {
                            Id = 6,
                            SizeName = "42"
                        });
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Order", b =>
                {
                    b.HasOne("sneakersShoesShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sneakersShoesShop.Models.OrderDetail", b =>
                {
                    b.HasOne("sneakersShoesShop.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sneakersShoesShop.Models.OrderRow", b =>
                {
                    b.HasOne("sneakersShoesShop.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Order", "Order")
                        .WithMany("OrderRows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sneakersShoesShop.Models.Product", b =>
                {
                    b.HasOne("sneakersShoesShop.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sneakersShoesShop.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
