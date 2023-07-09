using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
