using Microsoft.AspNetCore.Mvc;

namespace CoreCV.ViewComponents.Header
{
    public class HeaderList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
