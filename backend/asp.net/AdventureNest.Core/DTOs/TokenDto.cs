using System;

namespace AdventureNest.Core.DTOs
{
    public class TokenDto
    {
        public string Access { get; set; }

        public DateTime AccessExpiration { get; set; }

        public string Refresh { get; set; }

        public DateTime RefreshExpiration { get; set; }
    }
}
