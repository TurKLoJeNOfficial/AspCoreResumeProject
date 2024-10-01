using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using System.Data;

namespace CoreCV.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            p.Name = p.Icon;
            if (p.Icon == "Github")
            {
                p.Icon = "fab fa-github";
            }
            if (p.Icon == "Facebook")
            {
                p.Icon = "fab fa-facebook";
            }
            if (p.Icon == "Twitter")
            {
                p.Icon = "fab fa-twitter";
            }
            if (p.Icon == "Instagram")
            {
                p.Icon = "fab fa-instagram";
            }
            if (p.Icon == "Youtube")
            {
                p.Icon = "fab fa-youtube";
            }
            if (p.Icon == "Linkedln")
            {
                p.Icon = "fab fa-linkedin";
            }
            if (p.Icon == "Twitch")
            {
                p.Icon = "fab fa-twitch";
            }
            if (p.Icon == "Pinterest")
            {
                p.Icon = "fab fa-pinterest";
            }
            socialMediaManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia p)
        {
            p.Status = true;
            p.Name = p.Icon;
            if (p.Icon == "Github")
            {
                p.Icon = "fab fa-github";
            }
            if (p.Icon == "Facebook")
            {
                p.Icon = "fab fa-facebook";
            }
            if (p.Icon == "Twitter")
            {
                p.Icon = "fab fa-twitter";
            }
            if (p.Icon == "Instagram")
            {
                p.Icon = "fab fa-instagram";
            }
            if (p.Icon == "Youtube")
            {
                p.Icon = "fab fa-youtube";
            }
            if (p.Icon == "Linkedln")
            {
                p.Icon = "fab fa-linkedin";
            }
            if (p.Icon == "Twitch")
            {
                p.Icon = "fab fa-twitch";
            }
            if (p.Icon == "Pinterest")
            {
                p.Icon = "fab fa-pinterest";
            }
            socialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
