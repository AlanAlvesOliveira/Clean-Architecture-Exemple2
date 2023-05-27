namespace _1_Domain.Interfaces
{
    public interface IProcedureRepository
    {
        //TODO pode ser melhorado, por exemplo pode se não passar nenhum filtro
        public IList<TEntity> GetList<TEntity>(Dictionary<string,object> filtro) 
            where TEntity :class;
    }
}
