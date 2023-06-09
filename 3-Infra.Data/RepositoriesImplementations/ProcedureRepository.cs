﻿using _1_Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _3_Infra.Data.Repositories
{
    public class ProcedureRepository<TEntity, TContext> : IProcedureRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly DbSet<TEntity> _DbSet;
        public ProcedureRepository(TContext dbSet)
        {
            _DbSet = dbSet.Set<TEntity>();
        }

        public IList<TEntity> GetList(Dictionary<string, object> filtro)
        {
            string query = PreparaQuery(filtro);
            var param = new SqlParameter("@filtro","3");
            

            return _DbSet.FromSqlRaw("Exec  ProcTableExampleFiltro {0}",3 ).ToList();
        }
        

        public IList<TEntity> GetList()
        {
            throw new NotImplementedException();
        }

        private string PreparaQuery(Dictionary<string, object> filtro)
        {
            Dictionary<string, object> studentInfo = new Dictionary<string, object>
            {
                { "Filtro", "1" },                
            };

            string query = "";
            foreach (var item in filtro)
            {
                
                query = String.Concat(query ,"");
            }

            query = "Exec " + typeof(TEntity).Name;
            return query;


        }
    }
}
