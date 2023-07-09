using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
