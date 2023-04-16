using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureNest.Core.Models
{
    public class Publication : BaseEntity
    {
        public int PropertyId { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        // public float Rating { get; set; }

        // public string Location { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
    }
}
