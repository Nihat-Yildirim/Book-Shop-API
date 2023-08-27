using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Seeds
{
    public class ClaimSeed : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> builder)
        {
            builder.HasData(CreateSeedData());
        }

        private List<Claim> CreateSeedData()
        {
            List<Claim> claims = new()
            {
                new()
                {
                    Id = 1,
                    Name = "Customer"
                },
                new()
                {
                    Id = 2,
                    Name = "Admin"
                }
            };

            return claims;
        }
    }
}