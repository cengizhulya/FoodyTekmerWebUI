using FoodyTekmerDataAccessLayer.Context;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI_.Controllers
{
    public class CategoryController : Controller
    {
        FoodyContext context = new FoodyContext();
        public IActionResult Index()
        {
            var values = context.Categories.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category p)
        {
            context.Categories.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id ) //silme islemi idye gore yapilir
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);  //arkada sorguya donusur
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            context.Categories.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
