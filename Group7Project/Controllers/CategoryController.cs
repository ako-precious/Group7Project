using Group7Project.DataB;
using Group7Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group7Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public CategoryController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> category = _dbContext.Categories;
            return View(category);
        }
    }
}
