using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class OtpRecoveryCodeConfiguration : IEntityTypeConfiguration<OtpRecoveryCode>
    {
        public void Configure(EntityTypeBuilder<OtpRecoveryCode> builder)
        {
            builder.ToTable("OtpRecoveryCodes");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.OtpAuthentication)
                .WithMany(x => x.OtpRecoveryCodes)
                .HasForeignKey(x => x.OtpAuthenticationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Code)
                .HasColumnType(SqlServerColumnType.Char)
                .HasMaxLength(6)
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