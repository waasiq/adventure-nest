
using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Repositories;
using AdventureNest.Core.Services;
using AdventureNest.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenService _createTokenService;
        private readonly IGenericRepository<User> _userService;
        private readonly IGenericRepository<Token> _tokenService;
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(ITokenService createTokenService, IGenericRepository<User> userService,
            IGenericRepository<Token> tokenService, IUnitOfWork unitOfWork)
        {
            _createTokenService = createTokenService;
            _userService = userService;
            _tokenService = tokenService;
            _unitOfWork = unitOfWork;
        }

        //helper method
        private bool VerifyPasswordHash(string password, byte[] passwordSalt, byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes((string)password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        //login işlemi yapmak için kullanılır.
        public async Task<CustomResponseDto<TokenDto>> CreateToken(LoginDto loginDto)
        {
            if (loginDto == null) throw new ArgumentNullException(nameof(LoginDto));

            var user = _userService.Where(x => x.Email == loginDto.Email).FirstOrDefault();

            if (user == null) return CustomResponseDto<TokenDto>.Fail(404, "Email or password is wrong.");

            var verify = VerifyPasswordHash(loginDto.Password, user.PasswordSalt, user.PasswordHash);

            if (verify is false) return CustomResponseDto<TokenDto>.Fail(404, "Email or password is wrong.");

            var jwt = _createTokenService.CreateToken(user);

            var userRefreshToken = await _tokenService.Where(x => x.UserId == user.Id).SingleOrDefaultAsync();

            if(userRefreshToken is null)
            {
                var newToken = new Token()
                {
                    UserId = user.Id,
                    UserToken = jwt.Refresh,
                    ExpirationTime = jwt.RefreshExpiration
                };

                await _tokenService.AddAsync(newToken);
            }
            else
            {
                userRefreshToken.UserToken = jwt.Refresh;
                userRefreshToken.ExpirationTime = jwt.RefreshExpiration;
            }

            await _unitOfWork.CommitAsync();

            return CustomResponseDto<TokenDto>.Success(201, jwt);
        }

        //access token ömrü dolduktan sonra access token'ı yenilemek için kullanılır.
        public async Task<CustomResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _tokenService.Where(x => x.UserToken == refreshToken).SingleOrDefaultAsync();

            if(existRefreshToken == null)
            {
                return CustomResponseDto<TokenDto>.Fail(404, "Refresh token not found.");
            }

            var user = await _userService.GetByIdAsync(existRefreshToken.UserId);

            if(user == null)
            {
                return CustomResponseDto<TokenDto>.Fail(404, "User Id not found.");
            }

            var token = _createTokenService.CreateToken(user);

            existRefreshToken.UserToken = token.Refresh;
            existRefreshToken.ExpirationTime = token.RefreshExpiration;
            existRefreshToken.UserId = user.Id;

            _tokenService.Update(existRefreshToken);//burası kaldırılabilir
            await _unitOfWork.CommitAsync();

            return CustomResponseDto<TokenDto>.Success(201, token);
        }

        //logout işlemi yapmak için kullanılır.
        public async Task<CustomResponseDto<NoContentDto>> RevokeRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _tokenService.Where(x => x.UserToken == refreshToken).SingleOrDefaultAsync();

            if(existRefreshToken == null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, "Refresh token not found.");
            }

            _tokenService.Remove(existRefreshToken);

            await _unitOfWork.CommitAsync();

            return CustomResponseDto<NoContentDto>.Success(200);

        }
    }
}
