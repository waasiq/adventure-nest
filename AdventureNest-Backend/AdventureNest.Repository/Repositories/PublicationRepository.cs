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

        public async Task<List<PublicationAndPropertyDTO>> GetPublicationsWithAscendingPrice()
        {
            var x = await _context.Publications.OrderBy(x => x.Price).ToListAsync();
            var y = await _context.Properties.ToListAsync();

            List<PublicationAndPropertyDTO> list = new List<PublicationAndPropertyDTO>();
            PublicationAndPropertyDTO dto = new PublicationAndPropertyDTO();

            foreach (var item in x)
            {
                foreach (var item2 in y)
                {
                    if (item.PropertyId == item2.Id)
                    {
                        dto.Property = item2;
                        dto.Publication = item;
                        list.Add(dto);
                        break;
                    }
                }
            }
            return list;
        }

        public async Task<List<PublicationAndPropertyDTO>> GetPublicationsWithDescendingPrice()
        {
            var x = await _context.Publications.OrderByDescending(x => x.Price).ToListAsync();
            var y = await _context.Properties.ToListAsync();

            List<PublicationAndPropertyDTO> list = new List<PublicationAndPropertyDTO>();
            PublicationAndPropertyDTO dto = new PublicationAndPropertyDTO();

            foreach (var item in x)
            {
                foreach (var item2 in y)
                {
                    if (item.PropertyId == item2.Id)
                    {
                        dto.Property = item2;
                        dto.Publication = item;
                        list.Add(dto);
                        break;
                    }
                }
            }

            return list;

        }

        public async Task<List<PublicationAndPropertyDTO>> GetPublicationsWithProperties()
        {
            var x = await _context.Publications.ToListAsync();
            var y = await _context.Properties.ToListAsync();

            List<PublicationAndPropertyDTO> list = new List<PublicationAndPropertyDTO>();
            PublicationAndPropertyDTO dto = new PublicationAndPropertyDTO();

            foreach(var item in x)
            {
                foreach(var item2 in y) 
                {
                    if(item.PropertyId == item2.Id)
                    {
                        dto.Property = item2;
                        dto.Publication = item;
                        list.Add(dto);
                        
                        break;
                    }
                }
            }
            
            return list;
        }
    }
}
