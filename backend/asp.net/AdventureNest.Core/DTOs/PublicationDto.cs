using System;

namespace AdventureNest.Core.DTOs
{
    public class PublicationDto : BaseDto
    {
        public int Id { get; set; }

        public int PropertyID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
