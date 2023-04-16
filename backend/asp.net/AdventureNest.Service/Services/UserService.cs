using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Repositories;
using AdventureNest.Core.Services;
using AdventureNest.Core.UnitOfWorks;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Service.Services
{
    public class UserService : GenericService<User, UserDto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper,IUserRepository userRepository) : base(repository, unitOfWork, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<UserDto>> CreateUser(UserDto dto)
        {
            try
            {
                CreatePasswordHash(dto.Password, out byte[] passwordHash, out byte[] passwordSalt);
                var newUser = _mapper.Map<User>(dto);
                newUser.PasswordHash = passwordHash;
                newUser.PasswordSalt = passwordSalt;

                await _userRepository.CreateUserAsync(newUser);
                await _unitOfWork.CommitAsync();

                return CustomResponseDto<UserDto>.Success(201, dto);
            }
            catch (Exception ex)
            {
                return CustomResponseDto<UserDto>.Fail(400,ex.Message);
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordSalt, byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
