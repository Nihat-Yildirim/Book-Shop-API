using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookPictureRepositories
{
    public sealed class BookPictureWriteRepository : BaseWriteRepository<BookPicture>, IBookPictureWriteRepository
    {
        public BookPictureWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}