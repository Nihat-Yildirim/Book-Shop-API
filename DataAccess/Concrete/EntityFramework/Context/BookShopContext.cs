using Core.Entities.Concrete;
using Core.Utilities.Configurations;
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
            optionsBuilder.UseSqlServer("@"+Connection.ConnectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(c =>
            {
                c.ToTable("Customers").HasKey(c => c.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.FirstName).HasColumnName("FirstName");
                c.Property(p => p.LastName).HasColumnName("LastName");
                c.Property(p => p.Email).HasColumnName("Email");
                c.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
                c.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
                c.Property(p => p.ProfilePicture).HasColumnName("ProfilePicture");
                c.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                c.Property(p => p.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Dealer>(d =>
            {
                d.ToTable("Dealers").HasKey(d => d.Id);
                d.Property(p => p.Id).HasColumnName("Id");
                d.Property(p => p.StoreId).HasColumnName("StoreId");
                d.Property(p => p.FirstName).HasColumnName("FirstName");
                d.Property(p => p.LastName).HasColumnName("LastName");
                d.Property(p => p.Email).HasColumnName("Email");
                d.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
                d.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
                d.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                d.Property(p => p.Status).HasColumnName("Status");
            });
        }
    }
}