using System;

namespace AdventureNest.Core.DTOs
{
    public class PublicationsWithPropertyDto : PublicationDto
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PropertyType { get; set; }
        public string BookingType { get; set; }
        public string[] PhotographsPathList { get; set; }
    }
}
