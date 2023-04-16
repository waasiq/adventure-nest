using AdventureNest.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            var user1Password = "string1";
            CreatePasswordHash(user1Password, out byte[] user1PasswordHash, out byte[] user1PasswordSalt);

            var user2Password = "string2";
            CreatePasswordHash(user2Password, out byte[] user2PasswordHash, out byte[] user2PasswordSalt);

            var user3Password = "string3";
            CreatePasswordHash(user3Password, out byte[] user3PasswordHash, out byte[] user3PasswordSalt);

            builder.HasData(
                new User
                {
                    Id = 1,
                    Email = "string1@hotmail.com",
                    FirsName = "string1",
                    LastName = "string1",
                    ProfilePhotoPath = "string1",
                    Birthday = DateTime.Parse("1999-09-19 10:30:00"),
                    CreatedDate = DateTime.Parse("2023-09-09 10:30:00"),
                    PasswordSalt = user1PasswordSalt,
                    PasswordHash = user1PasswordHash
                },
                new User
                {
                    Id = 2,
                    Email = "string2@hotmail.com",
                    FirsName = "string2",
                    LastName = "string2",
                    ProfilePhotoPath = "string2",
                    Birthday = DateTime.Parse("1998-08-18 10:30:00"),
                    CreatedDate = DateTime.Parse("2023-08-08 10:30:00"),
                    PasswordSalt = user2PasswordSalt,
                    PasswordHash = user2PasswordHash
                },
                new User
                {
                    Id = 3,
                    Email = "string3@hotmail.com",
                    FirsName = "string3",
                    LastName = "string3",
                    ProfilePhotoPath = "string3",
                    Birthday = DateTime.Parse("1997-07-17 10:30:00"),
                    CreatedDate = DateTime.Parse("2023-07-07 10:30:00"),
                    PasswordSalt = user3PasswordSalt,
                    PasswordHash = user3PasswordHash
                });
        }
    }
}
