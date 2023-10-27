using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.AddressTitle)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(x => x.Province)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.District)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.OpenAddress)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(250)
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