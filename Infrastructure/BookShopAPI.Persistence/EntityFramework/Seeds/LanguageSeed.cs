using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Seeds
{
    public class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(CreateSeedData());
        }

        private List<Language> CreateSeedData()
        {
            List<Language> data = new()
            {
                new()
                {
                     Id = 1,
                     Name = "Türkçe"
                },
                new()
                {
                    Id = 2,
                    Name = "İngilizce"
                }
            };

            return data;
        }
    }
}