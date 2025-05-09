
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace MvcProdutoExemplo.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            var Aluno = new Aluno
            {
                Nome = "São João Gomes Cunha",
                Idade = 23,
                Curso = "Gastronomia"
            };
            return View(Aluno);
        }
    }
}