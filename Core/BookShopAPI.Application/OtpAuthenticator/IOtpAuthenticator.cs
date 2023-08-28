using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.OtpAuthenticator
{
    public interface IOtpAuthenticator
    {
        Task<byte[]> CreateSecretKeyAsync();
        Task<string> GenerateQrCodeUri(string sharedKey, string title, User user);
        Task<string> ConvertSecretKeyToStringAsync(byte[] sharedKey);  
        Task<bool> VerifyCodeAsync(byte[] secretKey , string code);
    }
}