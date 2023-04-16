using System;

namespace AdventureNest.Core.DTOs
{
    public class SignInDto
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public int ProfilePhoto { get; set; }

        public string ProfilePhotoPath { get; set; }
    }
}
