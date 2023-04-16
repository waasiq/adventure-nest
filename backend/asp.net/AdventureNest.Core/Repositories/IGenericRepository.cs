using System.Linq.Expressions;

namespace AdventureNest.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        //GetAll
        IQueryable<TEntity> GetAllAsync();

        //GetById
        Task<TEntity> GetByIdAsync(int id);

        //Add
        Task AddAsync(TEntity entity);

        //AddRange
        Task AddRangeAsync(IEnumerable<TEntity> entities);

        //Remove
        void Remove(TEntity entity);

        //RemoveRange
        void RemoveRange(IEnumerable<TEntity> entities);

        //Update
        void Update(TEntity entity);

        //Any
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        //Where
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
    }
}
