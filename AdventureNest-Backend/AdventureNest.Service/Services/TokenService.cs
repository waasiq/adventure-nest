using AdventureNest.Core.Configuration;
using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using AdventureNest.Repository.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Service.Services
{
    //Bu servisten API'ın haberi olmayacak, bu servisi AuthenticationService'te kullanacağız. 
    public class TokenService : ITokenService
    {
        private readonly CustomTokenOption _tokenOption;

        public TokenService(IOptions<CustomTokenOption> options)
        {
            _tokenOption = options.Value;
        }

        //helper method
        private string CreateRefreshToken()
        {
            var numberByte = new Byte[32];

            using var rnd = RandomNumberGenerator.Create();

            rnd.GetBytes(numberByte);

            return Convert.ToBase64String(numberByte);
        }

        //helper method
        private IEnumerable<Claim> GetClaims(User user, List<String> audiences)
        {
            var claimList = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            /* 
                foreach (var item in audiences)
                {
                    claimList.Add(new Claim(JwtRegisteredClaimNames.Aud, item));
                }
            */

            //Best way
            claimList.AddRange(audiences.Select(x => new Claim(JwtRegisteredClaimNames.Aud, x)));

            return claimList;
        }

        //main method
        public TokenDto CreateToken(User user)
        {
            var accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOption.AccessTokenExpiration);
            var refreshTokenExpiration = DateTime.Now.AddMinutes(_tokenOption.RefreshTokenExpiration);
            var securityKey = SignService.GetSymmetricSecurityKey(_tokenOption.SecurityKey);

            //imza bilgileri verilir
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            //token bilgileri verilir
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken
                (
                    issuer: _tokenOption.Issuer,
                    claims: GetClaims(user,_tokenOption.Audience),
                    expires: accessTokenExpiration,
                    notBefore: DateTime.Now,
                    signingCredentials: signingCredentials
                );

            //token oluşturacak yapı üretilir
            var handler = new JwtSecurityTokenHandler();

            //token oluşturulur
            var token = handler.WriteToken(jwtSecurityToken);

            var tokenDto = new TokenDto
            {
                Access = token,
                AccessExpiration = accessTokenExpiration,
                Refresh = CreateRefreshToken(),
                RefreshExpiration = refreshTokenExpiration
            };

            return tokenDto;
        }
    }
}
