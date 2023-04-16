using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Models
{
    public class Token
    {
        
        public int UserId { get; set; }

        public string UserToken { get; set; }

        public DateTime ExpirationTime { get; set; }
    }
}
