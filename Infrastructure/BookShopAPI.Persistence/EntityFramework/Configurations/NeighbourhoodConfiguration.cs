using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class NeighbourhoodConfiguration : IEntityTypeConfiguration<Neighbourhood>
    {
        public void Configure(EntityTypeBuilder<Neighbourhood> builder)
        {
            builder.ToTable("Neighbourhoods");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.District)
                .WithMany(x => x.Neighbourhoods)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(100)
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