using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class CommentRatingConfiguration : IEntityTypeConfiguration<CommentRating>
    {
        public void Configure(EntityTypeBuilder<CommentRating> builder)
        {
            builder.ToTable("CommentRatings");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.CommentRatings)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Comment)
                .WithMany(x => x.CommentRatings)
                .HasForeignKey(x => x.CommentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Useful)
                .HasColumnType(SqlServerColumnType.Bit)
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