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
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPhoneNumber> UserPhoneNumbers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

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
        }
    }
}