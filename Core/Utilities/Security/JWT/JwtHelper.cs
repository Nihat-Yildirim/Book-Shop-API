using Core.Entities.Abstract;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        private IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration= configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        public AccessToken CreateToken(User user)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions,user,signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new()
            {
                Token = token,
                Expiration= _accessTokenExpiration,
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,User user, SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                    issuer : _tokenOptions.Issuer,
                    audience : _tokenOptions.Audience,
                    expires : _accessTokenExpiration,
                    notBefore : DateTime.Now,
                    signingCredentials : signingCredentials
                );
            return jwt;
        }
    }
}