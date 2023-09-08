using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BasketRepositories
{
    public interface IBasketReadRepository : IReadRepository<Basket>
    {
        Task<BasketDto> GetBasketDtoAsync(int userId);
        Task<List<BasketForAdminDto>> GetBasketForAdminDtosAsync();
    }
}