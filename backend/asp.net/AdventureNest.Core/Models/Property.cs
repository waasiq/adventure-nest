using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureNest.Core.Models
{
    public class Property : BaseEntity
    {
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public float Latitude { get; set; }

        public float Longtitude { get; set; }

        public string PropertyType { get; set; }

        public string BookingType { get; set; }

        public string[] PhotographsPathList { get; set; }

        public int MaxGuestCount { get; set; }

        public int BedroomCount { get; set; }

        public int BathroomCount { get; set; }

        public int BedCount { get; set; }

        public bool IsRefrigerator { get; set; }

        public bool IsTv { get; set; }

        public bool IsCouch { get; set; }

        public bool IsBed{ get; set; }

        public bool IsGasStove { get; set; }

        public bool IsBlender { get; set; }

        public bool IsCoffeeMaker { get; set; }

        public bool IsMicrowave { get; set; }

        public bool IsMixingBowl { get; set; }

        public bool IsWashingMachine { get; set; }

        [ForeignKey("OwnerId")]
        public User User { get; set; }

        public Publication Publication { get; set; }
    }
}