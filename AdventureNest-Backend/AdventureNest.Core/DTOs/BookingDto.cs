using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.DTOs
{
    public class BookingDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int PublicationId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime DepartureDate { get; set; }

        public decimal PricePerDay { get; set; }

        public string BookingStatus { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
