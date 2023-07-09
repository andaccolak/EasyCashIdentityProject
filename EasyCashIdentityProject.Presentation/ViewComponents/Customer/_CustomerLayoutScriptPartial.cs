using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
