using _1_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _3_Infra.Data.Repositories
{
    public class CommandRepository<TEntity, TContext> : ICommandRepository<TEntity>
        where TEntity : class
        where TContext : DbContext        

    {
        private readonly DbSet<TEntity> _DbSet;
        private readonly TContext _Context;

        public CommandRepository(TContext context)
        {
            _DbSet = context.Set<TEntity>();
            _Context = context;
        }

        public void Add(TEntity entity)
        {
            _DbSet.Add(entity);
            _Context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> list)
        {
            _DbSet.AddRange(list);            
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public TEntity Find(int Id)
        {
            return _DbSet.Find(Id);
        }

        public void Remove(TEntity entity)
        {
            _DbSet.Remove(entity);
            _Context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> list)
        {
            _DbSet.RemoveRange(list);
            _Context.SaveChanges();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public IList<TEntity> ToList()
        {
            return _DbSet.ToList();
        }


        public void Update(TEntity entity)
        {
            _DbSet.Update(entity);
            _Context.SaveChanges();
        }

        public void UpdateRange(IEnumerable<TEntity> list)
        {
            _DbSet.UpdateRange(list);
            _Context.SaveChanges();
        }

        public IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _DbSet.Where(predicate).ToList();
        }

    }
}
