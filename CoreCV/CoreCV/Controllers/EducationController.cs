using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreCV.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EducationController : Controller
    {
        EducationManager educationManager = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Eğitim Listesi";
            ViewBag.v2 = "Eğitimler";
            ViewBag.v3 = "Eğitim Listesi";
            var values = educationManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            ViewBag.v1 = "Eğitim Ekleme";
            ViewBag.v2 = "Eğitimler";
            ViewBag.v3 = "Eğitim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            educationManager.TAdd(education);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = educationManager.TGetByID(id);
            educationManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            ViewBag.v1 = "Eğitim Güncelleme";
            ViewBag.v2 = "Eğitimler";
            ViewBag.v3 = "Eğitim Güncelleme";
            var values = educationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            educationManager.TUpdate(education);
            return RedirectToAction("Index");
        }
    }
}
