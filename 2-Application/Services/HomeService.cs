using _1_Domain.Entities.Tables;
using _1_Domain.Interfaces;
using _2_Application.Interfaces;
using _2_Application.ViewModels;

namespace _2_Application.Services
{
    public class HomeService : IHomeService
    {
        private readonly IQueryRepository<TableExample> _TableExampleRepo;

        public HomeService(IQueryRepository<TableExample> tableExampleRepo)
        {
            _TableExampleRepo = tableExampleRepo;
        }

        public HomeViewModels GetListaTableExample()
        {
            return  new HomeViewModels() {
                ListTableExample = _TableExampleRepo.ToListAsNoTracking()
            };                        
        }
    }
}
