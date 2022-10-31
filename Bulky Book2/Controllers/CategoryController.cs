using Bulky_Book2.Data;
using Bulky_Book2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky_Book2.wwwroot
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
            
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
