using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookPictureRepositories
{
    public sealed class BookPictureReadRepository : BaseReadRepository<BookPicture>, IBookPictureReadRepository
    {
        public BookPictureReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}