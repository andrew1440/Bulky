using Bulky_Book2.Data;
using Bulky_Book2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
        //GET
        public IActionResult Create()

        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View();
        }

        public Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary GetModelState()
        {
            return ModelState;
        }

        //POST
        [HttpPost ]
        [ValidateAntiForgeryToken ]
        public IActionResult Create(Category obj, Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {

                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

    }

}

   