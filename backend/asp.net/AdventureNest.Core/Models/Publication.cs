using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Models
{
    public class Publication : BaseEntity
    {
        public int PropertyId { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
    }
}
