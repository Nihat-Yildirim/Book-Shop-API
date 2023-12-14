using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class PublisherSearchDataConfiguration : IEntityTypeConfiguration<PublisherSearchData>
    {
        public void Configure(EntityTypeBuilder<PublisherSearchData> builder)
        {
            builder.ToTable("PublisherSearchDatas");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Publisher)
                .WithMany(x => x.PublisherSearchDatas)
                .HasForeignKey(x => x.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CreatedDate)
               .HasColumnType(SqlServerColumnType.DateTime2)
               .HasDefaultValue(DateTime.Now)
               .IsRequired();
        }
    }
}