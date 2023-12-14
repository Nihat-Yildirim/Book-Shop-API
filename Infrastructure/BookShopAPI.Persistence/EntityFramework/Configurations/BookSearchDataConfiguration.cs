using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class BookSearchDataConfiguration : IEntityTypeConfiguration<BookSearchData>
    {
        public void Configure(EntityTypeBuilder<BookSearchData> builder)
        {
            builder.ToTable("BookSearchDatas");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookSearchDatas)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CreatedDate)
               .HasColumnType(SqlServerColumnType.DateTime2)
               .HasDefaultValue(DateTime.Now)
               .IsRequired();
        }
    }
}