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

        //GET
        public IActionResult Create()
        {
             return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder and Name can not be the same");
            }
            if(ModelState.IsValid) { 
                _dbContext.Categories.Add(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder and Name can not be the same");
            }
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Add(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
