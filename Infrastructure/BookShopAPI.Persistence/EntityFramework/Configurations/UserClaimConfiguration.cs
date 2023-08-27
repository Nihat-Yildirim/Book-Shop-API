using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class UserClaimConfiguration : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.ToTable("UserClaims");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Claim)
                .WithMany(x => x.UserClaims)
                .HasForeignKey(x => x.ClaimId);

            builder.HasOne(x => x.User)
                .WithOne(x => x.UserClaim)
                .HasForeignKey<UserClaim>(x => x.UserId);

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