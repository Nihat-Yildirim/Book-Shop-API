using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Seeds
{
    public class UserClaimSeed : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.HasData(CreateSeedData());
        }

        private UserClaim CreateSeedData()
        {
            UserClaim userClaim = new();
            userClaim.Id = 1;
            userClaim.UserId = 1;
            userClaim.ClaimId = (int)Claims.Admin;
            userClaim.CreatedDate = DateTime.Now;

            return userClaim;
        }
    }
}