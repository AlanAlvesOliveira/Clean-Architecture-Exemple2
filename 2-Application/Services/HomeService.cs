using _1_Domain.Entities.Tables;
using _1_Domain.Interfaces;
using _2_Application.Interfaces;
using _2_Application.ViewModels;

namespace _2_Application.Services
{
    public class HomeService : IHomeService
    {
        private readonly IQueryRepository<TableExample> _TableExampleRepo;
        private readonly ICommandRepository<TableExample> _TableExampleCommand;

        public HomeService(IQueryRepository<TableExample> tableExampleRepo, ICommandRepository<TableExample> tableExampleCommand)
        {
            _TableExampleRepo = tableExampleRepo;
            _TableExampleCommand = tableExampleCommand;
        }

        public HomeViewModels GetListaTableExample()
        {
            //_TableExampleCommand.Add(new TableExample() { Campo1 = "TesteTeste" });
            //var teste = _TableExampleCommand.Find(7);
            //teste.Campo1 = "Teste7";
            //_TableExampleCommand.Update(teste);

            return  new HomeViewModels() {
                ListTableExample = _TableExampleRepo.ToListAsNoTracking()
            };                        
        }
    }
}
