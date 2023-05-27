using System.Linq.Expressions;

namespace _1_Domain.Interfaces
{
    public interface IQueryRepository<TEntity> where TEntity : class 
    {
        IList<TEntity> ToListAsNoTracking();
        IList<TEntity> WhereAsNoTracking(Expression<Func<TEntity,bool>> predicate);
        TEntity Find(int Id);
    }
}
