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
        public DbSet<File> Files { get; set; }
        public DbSet<Store> Stores { get; set; }

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

            modelBuilder.Entity<File>(f =>
            {
                f.ToTable("Files").HasKey(f => f.Id);
                f.Property(p => p.Id).HasColumnName("Id");
                f.Property(p => p.FileName).HasColumnName("FileName");
                f.Property(p => p.FilePath).HasColumnName("FilePath");
                f.Property(p => p.FileExtension).HasColumnName("FileExtension");
                f.Property(p => p.StorageName).HasColumnName("StorageName");
                f.Property(p => p.UploadDate).HasColumnName("UploadDate");
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
        }
    }
}