using Core.Entities.Concrete;
using Core.Utilities.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DbSet<CustomerAvatar> CustomerAvatars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Concrete.File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("Users").HasKey(u => u.Id);
                u.Property("FirstName").HasColumnName("FirstName");
                u.Property("LastName").HasColumnName("LastName");
                u.Property("Email").HasColumnName("Email");
                u.Property("PasswordHash").HasColumnName("PasswordHash");
                u.Property("PasswordSalt").HasColumnName("PasswordSalt");
                u.Property("Status").HasColumnName("Status");
                u.Property("CreatedDate").HasColumnName("CreatedDate");
            });

            modelBuilder.Entity<Customer>(c =>
            {
                c.ToTable("Customers").HasKey(c => c.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.UserId).HasColumnName("UserId");
            });

            modelBuilder.Entity<Dealer>(d =>
            {
                d.ToTable("Dealers").HasKey(d => d.Id);
                d.Property(p => p.Id).HasColumnName("Id");
                d.Property(p => p.StoreId).HasColumnName("StoreId");
                d.Property(p => p.UserId).HasColumnName("UserId");
            });

            modelBuilder.Entity<CustomerAvatar>(c =>
            {
                c.ToTable("CustomerAvatars").HasKey(c => c.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.CustomerId).HasColumnName("CustomerId");
                c.Property(p => p.FileId).HasColumnName("FileId");
            });

            modelBuilder.Entity<Entities.Concrete.File>(f =>
            {
                f.ToTable("Files").HasKey(f => f.Id);
                f.Property(f => f.Id).HasColumnName("Id");
                f.Property(f => f.FileName).HasColumnName("FileName");
                f.Property(f => f.FilePath).HasColumnName("FilePath");
                f.Property(f => f.FileExtension).HasColumnName("FileExtension");
                f.Property(f => f.StorageName).HasColumnName("StorageName");
                f.Property(f => f.UploadDate).HasColumnName("UploadDate");
            });
        }
    }
}