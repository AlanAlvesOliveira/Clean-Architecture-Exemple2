using System.Linq.Expressions;

namespace _1_Domain.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : class
    {
        IList<TEntity> ToList();
        IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(int Id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> list);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> list);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> list);
        int SaveChanges();
        void Dispose();
    }
}
