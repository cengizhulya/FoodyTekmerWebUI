using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI_.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
