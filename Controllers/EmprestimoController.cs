using EmprestimoDeLivros.Data;
using EmprestimoDeLivros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmprestimoDeLivros.Controllers
{    
    public class EmprestimoController : Controller
    {

        readonly private EmprestimoDbContext _db;
        public EmprestimoController(EmprestimoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimoModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpDelete]
        public IActionResult Excluir(EmprestimoModel emprestimos)
        {
            _db.Emprestimos.Remove(emprestimos);
            _db.SaveChanges();
            return View();

        }
    }
}
