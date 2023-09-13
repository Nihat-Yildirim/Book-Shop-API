using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.OtpAuthenticator
{
    public interface IOtpAuthenticator
    {
        byte[] CreateSecretKey();
        string GenerateQrCodeUri(string sharedKey, string title, User user);
        string ConvertSecretKeyToString(byte[] sharedKey);  
        bool VerifyCode(byte[] secretKey , string code);
    }
}