
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            var Filme = new Filme
            {
                NFilme = "Green Hell",
                Diretores = "Roberto Carlos Juior e Pablo Marçal",
                ALancamento = "Lançamento em 2030",
                Genero = "Ação/Comédia"
            };
            return View(Filme);
        }
    }
}