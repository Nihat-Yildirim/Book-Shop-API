using BookShopAPI.Application.Helpers.Encryption;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Tokens;
using BookShopAPI.Domain.Tokens.Options;
using BookShopAPI.Infrastructure.Helpers;
using System.IdentityModel.Tokens.Jwt;
using BookShopAPI.Infrastructure.Extensions;
using SecurityClaim = System.Security.Claims.Claim;
using Microsoft.IdentityModel.Tokens;

namespace BookShopAPI.Infrastructure.Tokens
{
    public class AccessTokenService : IAccessTokenService
    {
        private AccessTokenOptions _accessTokenOptions;
        private DateTime _accessTokenExpiration;
        public AccessTokenService()
        {
            _accessTokenOptions = AccessTokenOptionsHelper.GetAccessTokenOptions();
        }

        public AccessToken CreateAccessToken(User user, List<Claim> roles)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_accessTokenOptions.AccessTokenExpirationMinute);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_accessTokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(user, roles, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new()
            {
                Token = token,
                Expiration = _accessTokenExpiration,
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(User user, List<Claim> roles, SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                issuer: _accessTokenOptions.Issuer,
                audience: _accessTokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, roles),
                signingCredentials: signingCredentials
                );

            return jwt;
        }

        private IEnumerable<SecurityClaim> SetClaims(User user, List<Claim> roles)
        {
            List<SecurityClaim> claims = new();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName(user.FirstName + " " + user.LastName);
            claims.AddRoles(roles.Select(role => role.Name).ToArray());

            return claims;
        }
    }
}