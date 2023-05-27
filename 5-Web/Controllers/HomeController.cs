using _2_Application.Interfaces;
using _2_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _5_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            HomeViewModels vm = _service.GetListaTableExample();
            return View(vm);
        }
    }
}
