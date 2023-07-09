using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()    
        {
            return View();
        }
    }
}
