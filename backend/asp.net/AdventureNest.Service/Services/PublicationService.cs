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

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithProperties()
        {
            var publications = await _publicationRepository.GetPublicationsWithProperties();

            var publicationsWithPropertyDto = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);

            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, publicationsWithPropertyDto);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithAscendingPrice()
        {
            var publications = await _publicationRepository.GetPublicationsWithAscendingPrice();

            var publicationsWithPropertyDto = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);

            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, publicationsWithPropertyDto);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithDescendingPrice()
        {
            var publications = await _publicationRepository.GetPublicationsWithDescendingPrice();

            var publicationsWithPropertyDto = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);

            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, publicationsWithPropertyDto);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithHouseTypes(string houseType)
        {
            var publications = await _publicationRepository.GetPublicationsWithHouseTypes(houseType);

            var publicationsWithPropertyDto = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);

            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, publicationsWithPropertyDto);
        }

        public async Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithBookingTypes(string bookingType)
        {
            var publications = await _publicationRepository.GetPublicationsWithBookingTypes(bookingType);

            var publicationsWithPropertyDto = _mapper.Map<List<PublicationsWithPropertyDto>>(publications);

            return CustomResponseDto<List<PublicationsWithPropertyDto>>.Success(200, publicationsWithPropertyDto);
        }

    }
}
