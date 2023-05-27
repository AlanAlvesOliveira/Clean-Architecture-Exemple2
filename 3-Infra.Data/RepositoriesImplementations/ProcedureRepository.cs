using _1_Domain.Interfaces;

namespace _3_Infra.Data.Repositories
{
    public class ProcedureRepository : IProcedureRepository
    {
        public IList<TEntity> GetList<TEntity>(Dictionary<string, object> filtro) where TEntity : class
        {
            
            return null;
        }
    }
}
