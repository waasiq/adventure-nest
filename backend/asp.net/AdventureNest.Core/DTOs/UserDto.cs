using System;

namespace AdventureNest.Core.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public string Picture { get; set; }
    }
}
