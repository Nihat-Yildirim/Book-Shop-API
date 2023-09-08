using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Entities.Common;
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach(var entry in entries)
            {
                if(entry.State == EntityState.Added)
                    entry.Entity.CreatedDate = DateTime.Now;    

                if(entry.State == EntityState.Modified)
                    entry.Entity.UpdatedDate = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<BookPicture> BookPictures { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<PhoneNumberEntity> PhoneNumbers { get; set; }
        public DbSet<OtpRecoveryCode> OtpRecoveryCodes { get; set; }
        public DbSet<MailComfirmCode> MailComfirmCodes { get; set; }
        public DbSet<OtpAuthentication> OtpAuthentications { get; set; }
        public DbSet<MailAuthentication> MailAuthentications { get; set; }
    }
}