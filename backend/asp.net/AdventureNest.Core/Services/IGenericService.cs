using AdventureNest.Core.DTOs;
using System.Linq.Expressions;

namespace AdventureNest.Core.Services
{
    public interface IGenericService<TEntity,TDto> where TEntity : class 
        where TDto: class
    {
        //GetAll
        Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync();

        //GetById
        Task<CustomResponseDto<TDto>> GetByIdAsync(int id);

        //Add
        Task<CustomResponseDto<TDto>> AddAsync(TDto dto);

        //AddRange
        Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<TDto> dtos);

        //Remove
        Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);

        //RemoveRange
        Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<TDto> dtos);

        //Update
        Task<CustomResponseDto<NoContentDto>> Update(TDto dto, int id);

        //Any
        Task<bool> AnyAsync(Expression<Func<TDto, bool>> expression);

        //Where
        Task<CustomResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> expression);

    }
}
