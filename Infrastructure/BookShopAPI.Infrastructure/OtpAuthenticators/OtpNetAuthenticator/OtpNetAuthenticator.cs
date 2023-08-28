using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Domain.Entities;
using OtpNet;

namespace BookShopAPI.Infrastructure.OtpAuthenticators
{
    public sealed class OtpNetAuthenticator : IOtpAuthenticator
    {

        public Task<string> ConvertSecretKeyToStringAsync(byte[] sharedKey)
        {
            string base32String = Base32Encoding.ToString(sharedKey);

            return Task.FromResult(base32String);
        }

        public Task<byte[]> CreateSecretKeyAsync()
        {
            byte[] key = KeyGeneration.GenerateRandomKey(20);

            return Task.FromResult(key);
        }

        public Task<string> GenerateQrCodeUri(string sharedKey, string title, User user)
        {
            var qrCodeUri = $"otpauth://totp/{title}:{user.Email}?secret={sharedKey}&issuer={title}";
        
            return Task.FromResult(qrCodeUri);
        }

        public Task<bool> VerifyCodeAsync(byte[] sharedKey, string code)
        {
            Totp totp = new(sharedKey);

            string totpCode = totp.ComputeTotp(DateTime.UtcNow);
            bool result = totpCode == code;

            return Task.FromResult(result);
        }
    }
}