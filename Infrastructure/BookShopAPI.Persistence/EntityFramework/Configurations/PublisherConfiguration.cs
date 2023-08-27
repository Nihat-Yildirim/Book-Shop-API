using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.File)
                .WithOne(x => x.Publisher)
                .HasForeignKey<Publisher>(x => x.PublisherLogoFileId);

            builder.Property(x => x.Name)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
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