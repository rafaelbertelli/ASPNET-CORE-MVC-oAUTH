using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        // Lista de tarefas
        public IActionResult Index()
        {
            // Obter os dados e retornar
            return View();
        }
    }
}