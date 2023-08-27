using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class MailAuthenticationConfiguration : IEntityTypeConfiguration<MailAuthentication>
    {
        public void Configure(EntityTypeBuilder<MailAuthentication> builder)
        {
            builder.ToTable("MailAuthentications");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne(x => x.MailAuthentication)
                .HasForeignKey<MailAuthentication>(x => x.Id);

            builder.Property(x => x.ActivationKey)
                .HasColumnType(SqlServerColumnType.Char)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(x => x.ActivationDuration)
                .HasColumnType(SqlServerColumnType.DateTime2)
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