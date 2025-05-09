
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            var Carro = new Carro
            {
                Marca = "BMW",
                Modelo = "E36 328i",
                Ano = "1998"
            };
            return View(Carro);
        }
    }
}