using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class AuthorSearchDataConfiguration : IEntityTypeConfiguration<AuthorSearchData>
    {
        public void Configure(EntityTypeBuilder<AuthorSearchData> builder)
        {
            builder.ToTable("AuthorSearchDatas");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Author)
                .WithMany(x => x.AuthorSearchDatas)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CreatedDate)
               .HasColumnType(SqlServerColumnType.DateTime2)
               .HasDefaultValue(DateTime.Now)
               .IsRequired(); ;
        }
    }
}