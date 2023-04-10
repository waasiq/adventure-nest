using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.DTOs
{
    public class PublicationsWithPropertyDto
    {
        public PropertyDto PropertyDto { get; set; }
        public PublicationDto PublicationDto { get; set; }
    }
}
