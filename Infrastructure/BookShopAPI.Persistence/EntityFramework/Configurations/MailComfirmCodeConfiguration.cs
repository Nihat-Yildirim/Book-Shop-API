using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class MailComfirmCodeConfiguration : IEntityTypeConfiguration<MailComfirmCode>
    {
        public void Configure(EntityTypeBuilder<MailComfirmCode> builder)
        {
            builder.ToTable("MailComfirmCodes");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne(x => x.MailComfirmCode)
                .HasForeignKey<MailComfirmCode>(x => x.Id);

            builder.Property(x => x.ComfirmCode)
                .HasColumnType(SqlServerColumnType.Char)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(x => x.IsComfirm)
                .HasColumnType(SqlServerColumnType.Bit)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.ComfirmDuration)
                .HasColumnType(SqlServerColumnType.DateTime2)
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