using Microsoft.AspNetCore.Mvc;
using MvcProdutoExemplo.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produto = new Produto
            {
                Nome = "Teclado Mecânico",
                Preco = 349.90
            };
            return View(produto);
        }
    }
}