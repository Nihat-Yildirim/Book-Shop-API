using BookShopAPI.Domain.Mailing;

namespace BookShopAPI.Application.Mailing
{
    public interface IMailService
    {
        Task SendAsync(Mail mail);
    }
}