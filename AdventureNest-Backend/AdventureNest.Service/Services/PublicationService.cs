using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Repositories;
using AdventureNest.Core.Services;
using AdventureNest.Core.UnitOfWorks;
using AutoMapper;

namespace AdventureNest.Service.Services
{

    public class PublicationService : GenericService<Publication, PublicationDto>, IPublicationService
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IMapper _mapper;

        public PublicationService(IGenericRepository<Publication> repository, IUnitOfWork unitOfWork, IMapper mapper, IPublicationRepository publicationRepository) 
            : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _publicationRepository = publicationRepository;
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithAscendingPrice()
        {
            var publications = await _publicationRepository.GetPublicationsWithProperties();
            List<PublicationsWithPropertyDto> list = new List<PublicationsWithPropertyDto>();
            PublicationsWithPropertyDto dto = new PublicationsWithPropertyDto();

            foreach (var item in publications)
            {
                var x = _mapper.Map<PublicationDto>(item.Publication);
                var y = _mapper.Map<PropertyDto>(item.Property);
                dto.PropertyDto = y;
                dto.PublicationDto = x;
                list.Add(dto);
            }
            //var publicationsDtos = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);
            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, list);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithDescendingPrice()
        {
            var publications = await _publicationRepository.GetPublicationsWithProperties();
            List<PublicationsWithPropertyDto> list = new List<PublicationsWithPropertyDto>();
            PublicationsWithPropertyDto dto = new PublicationsWithPropertyDto();

            foreach (var item in publications)
            {
                var x = _mapper.Map<PublicationDto>(item.Publication);
                var y = _mapper.Map<PropertyDto>(item.Property);
                dto.PropertyDto = y;
                dto.PublicationDto = x;
                list.Add(dto);
            }
            //var publicationsDtos = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);
            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, list);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithProperties()
        {
            var publications = await _publicationRepository.GetPublicationsWithProperties();
            List<PublicationsWithPropertyDto> list = new List<PublicationsWithPropertyDto>();
            PublicationsWithPropertyDto dto = new PublicationsWithPropertyDto();

            foreach (var item in publications)
            {
                var x = _mapper.Map<PublicationDto>(item.Publication);
                var y = _mapper.Map<PropertyDto>(item.Property);
                dto.PropertyDto = y;
                dto.PublicationDto = x;
                list.Add(dto);
                dto.PropertyDto = null;
                dto.PublicationDto = null;
            }
            //var publicationsDtos = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);
            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200,list);
        }
       
    }
}
