using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.ToTable("Baskets");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Baskets)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.IsCompleted)
                .HasColumnType(SqlServerColumnType.Bit)
                .HasDefaultValue(false)
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