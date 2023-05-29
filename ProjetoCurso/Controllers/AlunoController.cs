using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjetoCurso.Data;
using ProjetoCurso.Models;

namespace ProjetoCurso.Controllers
{
    public class AlunoController : Controller
    {
        public readonly ApplicationDbContext _context;

            public AlunoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aluno =_context.Alunos.ToList();
            return View(aluno);
        }

        public IActionResult Create() //ativa a tela
        {
            var aluno = new Aluno();
            aluno.Nome = "Geovane";
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno) 
        {
           if(aluno != null)
            {
                _context.Alunos.Add(aluno);
                    _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
