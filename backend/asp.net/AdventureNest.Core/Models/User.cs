using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Models
{
    public class User : BaseEntity
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime Birthday { get; set; }

        public string ProfilePhotoPath { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
