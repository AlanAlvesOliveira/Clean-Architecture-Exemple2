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
    //TODO neste caso a implementação de query usa um TContext, porem a interface não, isso é correto? essa implentação não deveria vir tudo da interface
    //TODO tem também a questão do nulavel que eu desative para este projeto.
    public class QueryRepository<TEntity, TContext> : IQueryRepository<TEntity> where TEntity : class where TContext : DbContext
    {
        protected readonly DbSet<TEntity> _DbSet;

        public QueryRepository(TContext dbSet)
        {
            _DbSet = dbSet.Set<TEntity>();
        }

        public TEntity Find(int Id)
        {            
            return _DbSet.Find(Id);            
        }
         
        public  IList<TEntity> ToListAsNoTracking()
        {
            return _DbSet.AsNoTracking().ToList();
        }

        public IList<TEntity> WhereAsNoTracking(Expression<Func<TEntity, bool>> predicate)
        {
            return _DbSet.AsNoTracking().Where(predicate).ToList();
        }
    }
}
