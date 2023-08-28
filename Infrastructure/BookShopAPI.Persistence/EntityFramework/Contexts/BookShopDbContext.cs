using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookShopAPI.Persistence.EntityFramework.Contexts
{
    public class BookShopDbContext : DbContext
    {
        public BookShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<BookPicture> BookPictures { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<PhoneNumberEntity> PhoneNumbers { get; set; }
        public DbSet<OtpRecoveryCode> OtpRecoveryCodes { get; set; }
        public DbSet<OtpAuthentication> OtpAuthentications { get; set; }
        public DbSet<MailAuthentication> MailAuthentications { get; set; }
    }
}