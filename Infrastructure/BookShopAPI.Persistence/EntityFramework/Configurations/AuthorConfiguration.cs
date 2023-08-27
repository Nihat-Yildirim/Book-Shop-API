﻿using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.File)
                .WithOne(x => x.Author)
                .HasForeignKey<Author>(x => x.AuthorPictureFileId);

            builder.Property(x => x.FirstName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.FirstName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Autobiography)
                .HasColumnType(SqlServerColumnType.VarChar)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.Property(x => x.UpdatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(null);

            builder.Property(x => x.DeletedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(null);
        }
    }
}