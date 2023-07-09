using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
