using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Publisher)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.PublisherId);

            builder.Property(x => x.BookName)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Language)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.ISBN)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PaperType)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.SkinType)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.Dimension)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType(SqlServerColumnType.VarChar)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.ReleaseDate)
                .HasColumnType(SqlServerColumnType.Char)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.PageOfNumber)
                .HasColumnType(SqlServerColumnType.Int)
                .IsRequired();

            builder.Property(x => x.Stock)
                .HasColumnType(SqlServerColumnType.SmallInt)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnType(SqlServerColumnType.Decimal + "(18,2)")
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