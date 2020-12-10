using System;
using Microsoft.EntityFrameworkCore;
using SneakersShoesShop.Models;

namespace SneakersShoesShop.OrderContexts
{
    public class OrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } // Tabel Customers
        public DbSet<Product> Products { get; set; } // Tabel Products
        public DbSet<Order> Orders { get; set; } //Table Orders
        public DbSet<OrderDetail> OrderDetails { get; set; } // Table OrderDetails
        public DbSet<OrderRow> OrderRows { get; set; } //Table OrderRows

        public DbSet<Color> Colors { get; set; } // Table Colors
        public DbSet<Size> Sizes { get; set; } // Table Sizes
        public DbSet<Material> Type { get; set; } // Table Type
        public object Product { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sneakers-shoes-shop.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                FirstName = "Katarzyna",
                LastName = "Sz",
                Email = "kitty1@gmail.com",
                Telephone = 123456789,
                Registered = DateTime.Now.AddDays(-50)
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Sz",
                Email = "anna@gmail.com",
                Telephone = 123456789,
                Registered = DateTime.Now.AddDays(-10)
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                FirstName = "Piotr",
                LastName = "Sz",
                Email = "piotr90@gmail.com",
                Telephone = 123456789,
                Registered = DateTime.Now.AddDays(-5)
            });
            //order basket
            modelBuilder.Entity<Order>()
                .Property(o => o.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 1,
                CustomerId = 1,
                Status = "BASKET",
                Created = DateTime.Now,
            });
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 2,
                CustomerId = 2,
                Status = "onpaid",
                Created = DateTime.Now.AddHours(-3),
            });
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 3,
                CustomerId = 3,
                Status = "basket",
                Created = DateTime.Now.AddDays(-2),
            });
            // orderRow
            modelBuilder.Entity<OrderRow>()
                .Property(o => o.Id)
                .ValueGeneratedOnAdd();

            //product
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Design shoes monster",
                Price = 200,
                ActualCost = 200,
                ImageUrl = "/assets/images/shoesMonster.jpg",
                Details = "Hand painted shoes with nice monster",
                ColorId = 2,
                SizeId = 1,
                MaterialId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Design shoes Pac-Man",
                Price = 190,
                ActualCost = 190,
                ImageUrl = "/assets/images/shoesPac.jpg",
                Details = "Sentimentaly game, hand painted shoes",
                ColorId = 1,
                SizeId = 2,
                MaterialId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Design shoes Cat",
                Price = 380,
                ActualCost = 380,
                ImageUrl = "/assets/images/shoesCat.jpg",
                Details = "Hand painted shoes, perfect for cats lovers",
                ColorId = 4,
                SizeId = 3,
                MaterialId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Lether shoes",
                Price = 200,
                ActualCost = 200,
                ImageUrl = "/assets/images/shoesLetherW.jpg",
                Details = "Unisex shoes",
                ColorId = 4,
                SizeId = 4,
                MaterialId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Dark leather shoes",
                Price = 280,
                ActualCost = 280,
                ImageUrl = "/assets/images/shoesLetherG.jpg",
                Details = "Lether shoes in dark green color, perfect for rainy day",
                ColorId = 2,
                SizeId = 3,
                MaterialId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Pinky pink leather shoes",
                Price = 480,
                ActualCost = 480,
                ImageUrl = "/assets/images/shoesLetherP.jpg",
                Details = "Sweat pink shoes for every woman",
                ColorId = 3,
                SizeId = 3,
                MaterialId = 2
            });


            //color
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 1,
                ColorName = "black"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 2,
                ColorName = "green"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 3,
                ColorName = "pink"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 4,
                ColorName = "white"
            });
            //size 
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 1,
                SizeName = "35"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 2,
                SizeName = "36"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 3,
                SizeName = "37"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 4,
                SizeName = "38"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 5,
                SizeName = "40"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 6,
                SizeName = "42"
            });

            //material
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 1,
                MaterialName = "cotton and syntetic"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 2,
                MaterialName = "leather"
            });
            // order detail
            // modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail
            // {
            //     Id = 1,
            //     Quantity = 10,
            //     OrderId = 3,
            //     ProductId = 1,
            //     ColorId = 1,
            //     SizeId = 1,
            //     MaterialId = 2
            // });

            // modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail
            // {
            //     Id = 2,
            //     Quantity = 70,
            //     OrderId = 3,
            //     ProductId = 1,
            //     ColorId = 1,
            //     SizeId = 1,
            //     MaterialId = 1
            // });
            // modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail
            // {
            //     Id = 3,
            //     Quantity = 5,
            //     OrderId = 2,
            //     ProductId = 3,
            //     ColorId = 3,
            //     SizeId = 3,
            //     MaterialId = 2
            // });
        }
    }
}