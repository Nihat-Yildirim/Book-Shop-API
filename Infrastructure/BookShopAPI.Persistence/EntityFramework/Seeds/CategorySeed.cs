using BookShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopAPI.Persistence.EntityFramework.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateSeedDatas());
        }

        private List<Category> CreateSeedDatas()
        {
            List<Category> categories = new()
            {
                new()
                {
                    Id = 1,
                    ParentId = 0,
                    CategoryName = "Edebiyat"
                },
                new()
                {
                    Id = 2,
                    ParentId = 0,
                    CategoryName = "Tarih"
                },
                new()
                {
                    Id = 3,
                    ParentId = 0,
                    CategoryName = "Siyaset"
                },
                new()
                {
                    Id = 4,
                    ParentId = 0,
                    CategoryName = "Ekonomi"
                },
                new()
                {
                    Id = 5,
                    ParentId = 0,
                    CategoryName = "Eğitim"
                },
                new()
                {
                    Id = 6,
                    ParentId = 0,
                    CategoryName = "Sınav"
                },
                new()
                {
                    Id = 7,
                    ParentId = 0,
                    CategoryName = "Ders Kitapları"
                },
                new()
                {
                    Id = 8,
                    ParentId = 0,
                    CategoryName = "Kişisel Gelişim"
                },
                new()
                {
                    Id = 9,
                    ParentId = 0,
                    CategoryName = "Çocuk Kitapları"
                },
                new()
                {
                    Id = 10,
                    ParentId = 0,
                    CategoryName = "Dünya Klasikleri"
                },
                new()
                {
                    Id = 11,
                    ParentId = 0,
                    CategoryName = "Mitoloji Efsane"
                },
                new()
                {
                    Id = 12,
                    ParentId = 1,
                    CategoryName = "Roman"
                },
                new()
                {
                    Id = 13,
                    ParentId = 1,
                    CategoryName = "Öykü"
                },
                new()
                {
                    Id = 14,
                    ParentId = 1,
                    CategoryName = "Masal"
                },
                new()
                {
                    Id = 15,
                    ParentId = 1,
                    CategoryName = "Deneme"
                },
                new()
                {
                    Id = 16,
                    ParentId = 1,
                    CategoryName = "Biyografi"
                },
            };

            return categories;
        }
    }
}