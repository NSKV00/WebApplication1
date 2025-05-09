using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            var Livro = new Livro
            {
                Titulo = "São João Gomes Cunha",
                Autor = "Roberto Carlos Junior",
                QPaginas = 1128
            };
            return View(Livro);
        }
    }
}