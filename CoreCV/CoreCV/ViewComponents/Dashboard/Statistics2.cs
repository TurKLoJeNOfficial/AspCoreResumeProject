using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV.ViewComponents.Dashboard
{
    public class Statistics2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Experiences.Count();
            ViewBag.v2 = c.Services.Count();
            ViewBag.v3 = c.Educations.Count();
            return View();
        }
    }
}
