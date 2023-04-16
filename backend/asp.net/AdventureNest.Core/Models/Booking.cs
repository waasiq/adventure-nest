using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Models
{
    public class Booking : BaseEntity
    {
        public int CustomerId { get; set; }

        public int PublicationId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime DepartureDate { get; set; }

        public decimal PricePerDay { get; set; }

        public string BookingStatus { get; set; }

        public decimal TotalPrice { get; set; }

        [ForeignKey("PublicationId")]
        public Publication Publication { get; set; }
    }
}
