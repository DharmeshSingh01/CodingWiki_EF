using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LP-5CG2262DTM;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            var bookList = new Book[]{
                new Book { BookId=1, Title="Spider Without Deuty",ISBN="123B12",Price=10.99m,Publisher_Id=1 },
                new Book { BookId=2, Title="Fortune Of Time",ISBN="123B13",Price=9.99m,Publisher_Id = 2 },
                new Book { BookId=3, Title="Fake Sunday",ISBN="123B14",Price=8.99m,Publisher_Id=1 },
                new Book { BookId=4, Title="Cookies Jar",ISBN="123B15",Price=10.99m , Publisher_Id = 3},
                new Book { BookId=5, Title="Spider Without Deuty-2",ISBN="123B16",Price=11.99m,Publisher_Id=1 }
            };
            modelBuilder.Entity<Book>().HasData(bookList);
            
            modelBuilder.Entity<Publisher>().HasData(
                 new Publisher { Publisher_Id=1, Name="ABC"},
                 new Publisher { Publisher_Id = 2, Name = "BPC" },
                 new Publisher { Publisher_Id = 3, Name = "APress" }
                );
        }
    }
}
