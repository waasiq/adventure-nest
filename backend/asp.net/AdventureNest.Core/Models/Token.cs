using System;

namespace AdventureNest.Core.Models
{
    public class Token
    {
        
        public int UserId { get; set; }

        public string UserToken { get; set; }

        public DateTime ExpirationTime { get; set; }
    }
}
