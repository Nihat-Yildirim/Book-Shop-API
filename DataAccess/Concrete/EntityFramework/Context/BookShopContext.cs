using Core.Entities.Concrete;
using Core.Utilities.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using File = Entities.Concrete.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class BookShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@Connection.ConnectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPhoneNumber> UserPhoneNumbers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookOfCategory> BookOfCategories { get; set; }
        public DbSet<BookPicture> BookPictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("Users").HasKey(u => u.Id);
                u.Property(p => p.FirstName).HasColumnName("FirstName");
                u.Property(p => p.LastName).HasColumnName("LastName");
                u.Property(p => p.Email).HasColumnName("Email");
                u.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
                u.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
                u.Property(p => p.Status).HasColumnName("Status");
                u.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            });

            modelBuilder.Entity<Customer>(c =>
            {
                c.ToTable("Customers").HasKey(c => c.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.UserId).HasColumnName("UserId");
                c.Property(p => p.FileId).HasColumnName("FileId");
            });

            modelBuilder.Entity<Dealer>(d =>
            {
                d.ToTable("Dealers").HasKey(d => d.Id);
                d.Property(p => p.Id).HasColumnName("Id");
                d.Property(p => p.StoreId).HasColumnName("StoreId");
                d.Property(p => p.UserId).HasColumnName("UserId");
            });

            modelBuilder.Entity<File>(f =>
            {
                f.ToTable("Files").HasKey(f => f.Id);
                f.Property(p => p.Id).HasColumnName("Id");
                f.Property(p => p.FileName).HasColumnName("FileName");
                f.Property(p => p.FilePath).HasColumnName("FilePath");
                f.Property(p => p.FileExtension).HasColumnName("FileExtension");
                f.Property(p => p.StorageName).HasColumnName("StorageName");
                f.Property(p => p.UploadDate).HasColumnName("UploadDate");
                f.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Store>(s =>
            {
                s.ToTable("Stores").HasKey(s => s.Id);
                s.Property(p => p.Id).HasColumnName("Id");
                s.Property(p => p.FileId).HasColumnName("FileId");
                s.Property(p => p.Name).HasColumnName("Name");
                s.Property(p => p.Description).HasColumnName("Description");
                s.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<UserAddress>(u =>
            {
                u.ToTable("UserAddresses").HasKey(u => u.Id);
                u.Property(p => p.Id).HasColumnName("Id");
                u.Property(p => p.UserId).HasColumnName("UserId");
                u.Property(p => p.AddressTitle).HasColumnName("AddressTitle");
                u.Property(p => p.Description).HasColumnName("Description");
                u.Property(p => p.Province).HasColumnName("Province");
                u.Property(p => p.District).HasColumnName("District");
                u.Property(p => p.Neighbourhood).HasColumnName("Neighbourhood");
                u.Property(p => p.Address).HasColumnName("Address");
                u.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<UserPhoneNumber>(n =>
            {
                n.ToTable("UserPhoneNumbers").HasKey(n => n.Id);
                n.Property(p => p.Id).HasColumnName("Id");
                n.Property(p => p.UserId).HasColumnName("UserId");
                n.Property(p => p.PhoneTitle).HasColumnName("PhoneTitle");
                n.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber");
                n.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Author>(a =>
            {
                a.ToTable("Authors").HasKey(a => a.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.FileId).HasColumnName("FileId");
                a.Property(p => p.FirstName).HasColumnName("FirstName");
                a.Property(p => p.LastName).HasColumnName("LastName");
                a.Property(p => p.Autobiography).HasColumnName("Autobiography");
                a.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Publisher>(p =>
            {
                p.ToTable("Publishers").HasKey(p => p.Id);
                p.Property(p => p.Id).HasColumnName("Id");
                p.Property(p => p.FileId).HasColumnName("FileId");
                p.Property(p => p.Name).HasColumnName("Name");
                p.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories").HasKey(p => p.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.ParentId).HasColumnName("ParentId");
                c.Property(p => p.CategoryName).HasColumnName("CategoryName");
            });

            modelBuilder.Entity<Book>(b =>
            {
                b.ToTable("Books").HasKey(p => p.Id);
                b.Property(p => p.Id).HasColumnName("Id");
                b.Property(p => p.PublisherId).HasColumnName("PublisherId");
                b.Property(p => p.StoreId).HasColumnName("StoreId");
                b.Property(p => p.AuthorId).HasColumnName("AuthorId");
                b.Property(p => p.BookName).HasColumnName("BookName");
                b.Property(p => p.Language).HasColumnName("Language");
                b.Property(p => p.ReleaseDate).HasColumnName("ReleaseDate");
                b.Property(p => p.ISBN).HasColumnName("ISBN");
                b.Property(p => p.PaperType).HasColumnName("PaperType");
                b.Property(p => p.SkinType).HasColumnName("SkinType");
                b.Property(p => p.PageOfNumber).HasColumnName("PageOfNumber");
                b.Property(p => p.Dimension).HasColumnName("Dimension");
                b.Property(p => p.BookDescription).HasColumnName("BookDescription");
                b.Property(p => p.Stock).HasColumnName("Stock");
                b.Property(p => p.Price).HasColumnName("Price");
                b.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                b.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<BookOfCategory>(b =>
            {
                b.ToTable("BookOfCategories").HasKey(p => p.Id);
                b.Property(p => p.Id).HasColumnName("Id");
                b.Property(p => p.BookId).HasColumnName("BookId");
                b.Property(p => p.CategoryId).HasColumnName("CategoryId");
            });

            modelBuilder.Entity<BookPicture>(b =>
            {
                b.ToTable("BookPictures").HasKey(p => p.Id);
                b.Property(p => p.Id).HasColumnName("Id");
                b.Property(p => p.BookId).HasColumnName("BookId");
                b.Property(p => p.FileId).HasColumnName("FileId");
                b.Property(p => p.Show).HasColumnName("Show");
            });
        }
    }
}