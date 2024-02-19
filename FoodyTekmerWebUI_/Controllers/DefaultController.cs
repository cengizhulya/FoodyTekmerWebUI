using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI_.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Ürünler";  //viewbag ile her tür tasinabiliyor
            ViewBag.title2 = "Ana sayfa";
            ViewBag.title3 = "Sayfalar";
            ViewBag.title4 = "Ürün Listesi";
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialPageHeader()
        {
            return PartialView();
        }
    }
}
