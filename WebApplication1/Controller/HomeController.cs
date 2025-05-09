using Microsoft.AspNetCore.Mvc;

namespace MvcProdutoExemplo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}