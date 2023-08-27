using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.File)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.UserAvatarFileId);

            builder.Property(x => x.FirstName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.IsComfirmed)
                .HasColumnType(SqlServerColumnType.Bit)
                .IsRequired();

            builder.Property(x => x.PasswordHash)
                .HasColumnType(SqlServerColumnType.VarBinary)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.PasswordSalt)
                .HasColumnType(SqlServerColumnType.VarBinary)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.AuthenticatorType)
                .HasColumnType(SqlServerColumnType.Char)
                .HasDefaultValue(AuthenticatorType.None)
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.Property(x => x.UpdatedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(null);

            builder.Property(x => x.DeletedDate)
                .HasColumnType(SqlServerColumnType.DateTime2)
                .HasDefaultValue(null);
        }
    }
}