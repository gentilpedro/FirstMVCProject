using FirstMVCProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class LancheController : Controller
    {
         private readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult LancheList()
        {
            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;

            return View(lanches);
        }
    }
}
