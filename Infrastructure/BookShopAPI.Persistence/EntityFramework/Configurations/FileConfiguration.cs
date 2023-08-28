using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookShopAPI.Domain.Constants;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<FileEntity>
    {
        public void Configure(EntityTypeBuilder<FileEntity> builder)
        {
            builder.ToTable("Files");

            builder.Property(x => x.FileName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.FilePath)
                .HasColumnType(SqlServerColumnType.VarChar)
                .IsRequired();

            builder.Property(x => x.FileExtension)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.Property(x => x.UpdatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .IsRequired(false);
        }
    }
}