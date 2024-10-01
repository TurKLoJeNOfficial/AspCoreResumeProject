using Microsoft.AspNetCore.Mvc;

namespace CoreCV.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
