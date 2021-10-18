using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Two.Entity;

namespace Two
{
    public class DBHomeWorkOne : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=DESKTOP-2F7F08E;Database=HomeWW1P2;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().HasKey(vf => new { vf.Madt, vf.Magv, vf.MaSv });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id=1,
                    Name = "Dung Bui",
                    Count = 2000,
                    PublishDate = DateTime.Now
                },
                new Book
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Count = 2005,
                    PublishDate = DateTime.Now
                    
                }
                );
        }

    }
}
