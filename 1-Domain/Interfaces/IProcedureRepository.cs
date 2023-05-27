namespace _1_Domain.Interfaces
{
    public interface IProcedureRepository<TEntity> where TEntity : class
    {
        //TODO pode ser melhorado, por exemplo pode se não passar nenhum filtro
        public IList<TEntity> GetList(Dictionary<string, object> filtro);
            
    }
}
