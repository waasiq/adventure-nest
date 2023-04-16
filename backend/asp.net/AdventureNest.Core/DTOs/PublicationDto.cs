using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.DTOs
{
    public class PublicationDto : BaseDto
    {
        public int Id { get; set; }

        public int PropertyID { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
