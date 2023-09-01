using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumberEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneNumberEntity> builder)
        {
            builder.ToTable("PhoneNumbers");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.PhoneNumbers)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.PhoneTitle)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(45)
                .IsRequired(false);

            builder.Property(x => x.PhoneNumber)
                .HasColumnType(SqlServerColumnType.Char)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Selected)
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

            builder.Property(x => x.DeletedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .IsRequired(false);
        }
    }
}