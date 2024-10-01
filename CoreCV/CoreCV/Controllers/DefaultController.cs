using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public PartialViewResult SendMessage()

        {

            return PartialView();

        }

        [HttpPost]

        public IActionResult SendMessage(Message p)

        {

            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            p.Status = false;

            messageManager.TAdd(p);

            return RedirectToAction("Index", "Default");

        }
    }
}
