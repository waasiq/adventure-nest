using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Repository.Repositories
{
    public class PublicationRepository : GenericRepository<Publication>, IPublicationRepository
    {
        public PublicationRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Publication>> GetPublicationsWithProperties()
        {
            var publications = await _context.Publications.Include(x => x.Property).ToListAsync();
            return publications;
        }

        public async Task<List<Publication>> GetPublicationsWithAscendingPrice()
        {
            var publications = await _context.Publications.Include(x => x.Property).OrderBy(y => y.Price).ToListAsync();
            return publications;
        }

        public async Task<List<Publication>> GetPublicationsWithDescendingPrice()
        {
            var publications = await _context.Publications.Include(x => x.Property).OrderByDescending(y => y.Price).ToListAsync();
            return publications;
        }

        public async Task<List<Publication>> GetPublicationsWithHouseTypes(string houseType)
        {
            var publications = await _context.Publications.Include(x => x.Property)
                .Where(z => z.Property.PropertyType == houseType).ToListAsync();
            return publications;
        }

        public async Task<List<Publication>> GetPublicationsWithBookingTypes(string bookingType)
        {
            var publications = await _context.Publications.Include(x => x.Property)
                .Where(z => z.Property.BookingType == bookingType).ToListAsync();
            return publications;
        }
    }
}
