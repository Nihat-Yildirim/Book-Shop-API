using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class OtpAuthenticationConfiguration : IEntityTypeConfiguration<OtpAuthentication>
    {
        public void Configure(EntityTypeBuilder<OtpAuthentication> builder)
        {
            builder.ToTable("OtpAuthentications");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne(x => x.OtpAuthentication)
                .HasForeignKey<OtpAuthentication>(x => x.Id);

            builder.Property(x => x.SecretKey)
                .HasColumnType(SqlServerColumnType.VarBinary)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.IsVerified)
                .HasColumnType(SqlServerColumnType.Bit)
                .HasDefaultValue(false)
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