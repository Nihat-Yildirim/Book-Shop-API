using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class BookPictureConfiguration : IEntityTypeConfiguration<BookPicture>
    {
        public void Configure(EntityTypeBuilder<BookPicture> builder)
        {
            builder.ToTable("BookPictures");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.File)
                .WithOne(x => x.BookPicture)
                .HasForeignKey<BookPicture>(x => x.BookPictureFileId);

            builder.Property(x => x.ShowOrder)
                .HasColumnType(SqlServerColumnType.TinyInt)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.Property(x => x.UpdatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(null);
        }
    }
}