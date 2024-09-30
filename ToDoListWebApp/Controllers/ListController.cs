using Microsoft.AspNetCore.Mvc;

namespace ToDoListWebApp.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
