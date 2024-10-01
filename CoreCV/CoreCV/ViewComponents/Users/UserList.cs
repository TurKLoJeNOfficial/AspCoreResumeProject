using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreCV.ViewComponents.Users
{
    public class UserList : ViewComponent
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());

        public IViewComponentResult Invoke()
        {
            var values = writerUserManager.TGetList().OrderByDescending(x => x.Id).Take(6).ToList();
            return View(values);
        }
    }
}
