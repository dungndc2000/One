using Four.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four
{
    public class DbContextFour : DbContext
    {


        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailsInvoice> DetailsInvoices { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=DESKTOP-2F7F08E;Database=Four;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DetailsInvoice>().HasKey(vc => new { vc.Invoice, vc.Product });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id=1,
                    Name = "Thúy Thị Kiều",
                    Address = "Ngã 4 Khuất Duy Tiến",
                    DateOfBirth = DateTime.Now,
                    Gender = Enum.Gender.Female
                },
                new Customer
                {
                    Id=2,
                    Name = "Thúy Thị Vân",
                    Address = "Ngã 3 Khuất Duy Tiến",
                    DateOfBirth = DateTime.Now,
                    Gender = Enum.Gender.Female
                },
                new Customer
                {
                    Id=3,
                    Name = "Chí Phèo",
                    Address = "Ngã 4 Trần Duy Hưng",
                    DateOfBirth = DateTime.Now,
                    Gender = Enum.Gender.Male
                },
                new Customer
                {
                    Id=4,
                    Name = "Lão Hạc",
                    Address = "Ngã 4 Thanh Xuân",
                    DateOfBirth = DateTime.Now,
                    Gender = Enum.Gender.Male
                },
                new Customer
                {
                    Id=5,
                    Name = "Cậu Vàng",
                    Address = "Ngã 3 Dịch Vọng",
                    DateOfBirth = DateTime.Now,
                    Gender = Enum.Gender.Male
                }
                );
            modelBuilder.Entity<Invoice>().HasData(
                new Invoice
                {
                    Id=1,
                    CustomerID = 1,
                    Price = 23000,
                    //InvoiceDay = DateTime.Now
                },
                new Invoice
                {
                    Id=2,
                    CustomerID = 2,
                    Price = 25000,
                    //InvoiceDay = DateTime.Now
                },
                new Invoice
                {
                    Id=3,
                    CustomerID = 3,
                    Price = 50000,
                    //InvoiceDay = DateTime.Now
                },
                new Invoice
                {
                    Id=4,
                    CustomerID = 4,
                    Price = 27000,
                    //InvoiceDay = DateTime.Now
                },
                new Invoice
                {
                    Id=5,
                    CustomerID = 5,
                    Price = 40000,
                    //InvoiceDay = DateTime.Now
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id=1,
                    Name = "Sữa đặc ông thọ",
                    Unit = "Lon",
                    Price = 23000
                },
                new Product
                {
                    Id=2,
                    Name = "Kẹo dẻo Hồng Hà",
                    Unit = "Gói",
                    Price = 20000
                },
                new Product
                {
                    Id=3,
                    Name = "Bánh xốp Kinh Đô",
                    Unit = "Hộp",
                    Price = 75000
                },
                new Product
                {
                    Id=4,
                    Name = "Bánh xốp Luxury",
                    Unit = "Hộp",
                    Price = 120000
                },
                new Product
                {
                    Id=5,
                    Name = "Đường trắng Quy Hòa",
                    Unit = "Gói",
                    Price = 15000
                }
                );
            modelBuilder.Entity<DetailsInvoice>().HasData(
                new DetailsInvoice
                {
                    Id=1,
                    InvoiceID=1,
                    ProductID=1,
                    Count = 3
                },
                new DetailsInvoice
                {
                    Id=2,
                    InvoiceID = 2,
                    ProductID = 2,
                    Count = 2
                },
                new DetailsInvoice
                {
                    Id=3,
                    InvoiceID = 3,
                    ProductID = 3,
                    Count = 1
                },
                new DetailsInvoice
                {
                    Id=4,
                    InvoiceID = 4,
                    ProductID = 4,
                    Count = 5
                },
                new DetailsInvoice
                {
                    Id=5,
                    InvoiceID = 5,
                    ProductID = 5,
                    Count = 7
                }
                );
        }

    }
}
