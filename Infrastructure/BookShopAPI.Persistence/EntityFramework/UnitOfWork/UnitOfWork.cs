using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Persistence.EntityFramework.Contexts;

namespace BookShopAPI.Persistence.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookShopDbContext _context;
        public UnitOfWork(BookShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}