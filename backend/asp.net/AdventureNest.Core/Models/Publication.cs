using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureNest.Core.Models
{
    public class Publication : BaseEntity
    {
        public int PropertyId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
    }
}
