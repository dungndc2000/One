using Microsoft.EntityFrameworkCore;
using One.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using One.Enum;


namespace One
{
    public class BuySellDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailsInvoice> DetailsInvoices { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=DESKTOP-2F7F08E;Database=A;Trusted_Connection=True;");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailsInvoice>().HasKey(vf => new { vf.InvoiceId,vf.ProductId });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Name = "Nguyễn Thị Mai Chi",
                    Address = "Thái Bình",
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Female
                },
                new Customer
                {
                    Name = "Phan Văn A",
                    Address = "Quy Nhơn",
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Male
                },
                new Customer
                {
                    Name = "Nguyễn Thúy Kiều",
                    Address = "Lạng Sơn",
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Female
                },
                new Customer
                {
                    Name = "Nguyễn Thúy Vân",
                    Address = "Hà Nội",
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Female
                },
                new Customer
                {
                    Name = "Trần Hoàng B",
                    Address = "Sài Gòn",
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Male
                }
                );
            modelBuilder.Entity<DetailsInvoice>().HasData(
                new DetailsInvoice
                {
                    Quantity = 3,
                  
                },
                new DetailsInvoice
                {
                    Quantity = 2
                },
                new DetailsInvoice
                {
                    Quantity = 1
                },
                new DetailsInvoice
                {
                    Quantity = 5
                },
                new DetailsInvoice
                {
                    Quantity = 4
                }
                );
            modelBuilder.Entity<Invoice>().HasData(
                new Invoice
                {
                    Price = 23000,
                    Day = DateTime.Now
                },
                new Invoice
                {
                    Price = 200000,
                    Day = DateTime.Now
                },
                new Invoice
                {
                    Price = 120000,
                    Day = DateTime.Now
                },
                new Invoice
                {
                    Price = 263000,
                    Day = DateTime.Now
                },
                new Invoice
                {
                    Price = 17000,
                    Day = DateTime.Now
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Name = "Sữa đặc ông thọ",
                    Unit = "Lon",
                    UnitPrice = 23000
                },
                new Product
                {
                    Name = "Kẹo dẻo Hồng Hà",
                    Unit = "Gói",
                    UnitPrice = 80000
                },
                new Product
                {
                    Name = "Bánh xốp Kinh Đô",
                    Unit = "Hộp",
                    UnitPrice = 120000
                },
                new Product
                {
                    Name = "Bánh xốp Luxury",
                    Unit = "Hộp",
                    UnitPrice = 150000
                },
                new Product
                {
                    Name = "Đường trắng Quy Hòa",
                    Unit = "Hộp",
                    UnitPrice = 20000
                }
                );
        }
    }
}
