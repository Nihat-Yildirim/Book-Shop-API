using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateSeedData());
        }

        private User CreateSeedData()
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("785asd748vn%dj125", out passwordHash, out passwordSalt);

            User user = new();
            user.Id = 1;
            user.FirstName = "Admin";
            user.LastName = "Admin";
            user.Email = "BookShopAdmin@gmail.com";
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.AuthenticatorType = AuthenticatorType.None;
            user.CreatedDate = DateTime.Now;

            return user;
        }
    }
}