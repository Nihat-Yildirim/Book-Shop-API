using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
    {
        public void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder.ToTable("BasketItems");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Basket)
                .WithMany(x => x.BasketItems)
                .HasForeignKey(x => x.BasketId);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BasketItems)
                .HasForeignKey(x => x.BookId);

            builder.Property(x => x.Quantity)
                .HasColumnType(SqlServerColumnType.TinyInt)
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