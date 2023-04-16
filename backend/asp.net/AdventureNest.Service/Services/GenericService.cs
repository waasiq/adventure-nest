using AdventureNest.Core.DTOs;
using AdventureNest.Core.Repositories;
using AdventureNest.Core.Services;
using AdventureNest.Core.UnitOfWorks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace AdventureNest.Service.Services
{
    public class GenericService<TEntity, TDto> : IGenericService<TEntity, TDto> where TEntity : class
        where TDto : class
    {

        protected readonly IGenericRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<TDto>> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            var newDto = _mapper.Map<TDto>(entity);

            return CustomResponseDto<TDto>.Success(201, newDto);

        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<TDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();

            var newDtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return CustomResponseDto<IEnumerable<TDto>>.Success(201, newDtos);
        }

        public Task<bool> AnyAsync(Expression<Func<TDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = _repository.GetAllAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return CustomResponseDto<IEnumerable<TDto>>.Success(200,dtos);
        }

        public async Task<CustomResponseDto<TDto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity is null)
            {
                return CustomResponseDto<TDto>.Fail(404, "Data has not found.");
            }

            var dto = _mapper.Map<TDto>(entity);

            return CustomResponseDto<TDto>.Success(200,dto);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if(entity is null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, "Data has not found.");
            }

            _repository.Remove(entity);
            _unitOfWork.Commit();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<TDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(dtos);
            if(entities is null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, "Datas have not found");
            }
            _repository.RemoveRange(entities);
            _unitOfWork.Commit();

            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<NoContentDto>> Update(TDto dto, int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            var updatedEntity = _mapper.Map<TEntity>(dto);

            if(entity is null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, "Data has not found.");
            }
            _repository.Update(updatedEntity);
            _unitOfWork.Commit();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> expression)
        {
            var entities = _repository.Where(expression);
            var dto = _mapper.Map<IQueryable<TDto>>(entities);

            return CustomResponseDto<IEnumerable<TDto>>.Success(200, await dto.ToListAsync());
        }
    }
}
