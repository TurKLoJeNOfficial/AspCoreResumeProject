using Microsoft.AspNetCore.Mvc;

namespace CoreCV.ViewComponents.Navbar
{
    public class NavbarList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
