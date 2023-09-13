using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Domain.Entities;
using OtpNet;

namespace BookShopAPI.Infrastructure.OtpAuthenticators
{
    public sealed class OtpNetAuthenticator : IOtpAuthenticator
    {

        public string ConvertSecretKeyToString(byte[] sharedKey)
        {
            string base32String = Base32Encoding.ToString(sharedKey);

            return base32String;
        }

        public byte[] CreateSecretKey()
        {
            byte[] key = KeyGeneration.GenerateRandomKey(20);

            return key;
        }

        public string GenerateQrCodeUri(string sharedKey, string title, User user)
        {
            var qrCodeUri = $"otpauth://totp/{title}:{user.Email}?secret={sharedKey}&issuer={title}";
        
            return qrCodeUri;
        }

        public bool VerifyCode(byte[] sharedKey, string code)
        {
            Totp totp = new(sharedKey);

            string totpCode = totp.ComputeTotp(DateTime.UtcNow);
            bool result = totpCode == code;

            return result;
        }
    }
}