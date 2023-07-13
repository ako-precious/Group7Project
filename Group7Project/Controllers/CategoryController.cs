using Microsoft.AspNetCore.Mvc;

namespace Group7Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
