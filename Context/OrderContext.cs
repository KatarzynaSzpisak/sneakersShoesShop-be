using System;
using onlineTShirtShop.Models;
using Microsoft.EntityFrameworkCore;

namespace onlineTShirtShop.OrderContexts
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
        public DbSet<Material> Materials { get; set; } // Table Materials
        public object Product { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=onlineshop.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                FirstName = "Tanya",
                LastName = "L",
                Email = "tanya.l@l.se",
                Telephone = 123456789,
                Registered = DateTime.Now.AddDays(-50)
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                FirstName = "Dima",
                LastName = "L",
                Email = "dima.l@l.se",
                Telephone = 123456789,
                Registered = DateTime.Now.AddDays(-10)
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                FirstName = "Kolya",
                LastName = "L",
                Email = "kolya.l@l.com",
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
                Name = "Cats TShirt",
                Price = 100,
                ActualCost = 100,
                ImageUrl = "/assets/images/test1.jpg",
                Details = "Unik cats tshirt, hand made design",
                ColorId = 1,
                SizeId = 1,
                MaterialId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Classic TShirt",
                Price = 90,
                ActualCost = 90,
                ImageUrl = "/assets/images/test2.jpg",
                Details = "Unik classic tshirt, hand made design",
                ColorId = 2,
                SizeId = 2,
                MaterialId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Unisex TShirt",
                Price = 80,
                ActualCost = 80,
                ImageUrl = "/assets/images/test3.jpg",
                Details = "Unik unisex tshirt, hand made design",
                ColorId = 3,
                SizeId = 3,
                MaterialId = 1
            });
            //color
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 1,
                ColorName = "red"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 2,
                ColorName = "green"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 3,
                ColorName = "blue"
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 4,
                ColorName = "black"
            });
            //size 
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 1,
                SizeName = "XS"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 2,
                SizeName = "S"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 3,
                SizeName = "M"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 4,
                SizeName = "L"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 5,
                SizeName = "XL"
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 6,
                SizeName = "XXL"
            });
            //material
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 1,
                MaterialName = "cotton"
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