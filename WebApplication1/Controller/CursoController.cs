
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            var Curso = new Curso
            {
                Nome = "Habilotação AB",
                Duracao = "200 Horas",
                Instrutor = "Pablo Marçal"
            };
            return View(Curso);
        }
    }
}