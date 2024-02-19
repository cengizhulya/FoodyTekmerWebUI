using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI_.ViewComponents
{
    public class ScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
