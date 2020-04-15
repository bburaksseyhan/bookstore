using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BookStore.Application.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration Configuration;
        private readonly ITokenRepository _tokenRepository;

        public TokenService(IConfiguration configuration, ITokenRepository tokenRepository)
        {
            Configuration = configuration;
            _tokenRepository = tokenRepository;
        }

        public string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(number);
                return Convert.ToBase64String(number);
            }
        }

        public string GetRefreshToken(string refreshToken)
        {
            return _tokenRepository.GetRefreshToken(refreshToken);
        }

        public Dictionary<string, object> GetToken(string emailAddress)
        {
            var dictionary = new Dictionary<string, object>();
            var expires = DateTime.Now.AddMinutes(10);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Email, emailAddress)
            };

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]));

            var token = new JwtSecurityToken(
                issuer: Configuration["JWT:Issuer"],
                audience: Configuration["JWT:Audience"],
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);

            dictionary.Add("Token", encodedJwt);
            dictionary.Add("Expiration", expires);

            return dictionary;
        }

        public bool UpdateUserTokens(UpdateUserViewModel updateUserViewModel)
        {
            return _tokenRepository.UpdateUserToken(updateUserViewModel.Id,
                                                    updateUserViewModel.RefreshToken,
                                                    updateUserViewModel.Token);
        }

        public bool ValidateToken(string token)
        {
            bool result = false;

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            bool canRead = tokenHandler.CanReadToken(token);
            SecurityToken securityToken;

            if (canRead)
            {
                var data = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]));

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidIssuer = Configuration["JWT:Issuer"],
                    ValidAudience = Configuration["JWT:Audience"],
                    IssuerSigningKey = data
                }, out securityToken);

                result = true;
            }

            return result;
        }
    }
}
