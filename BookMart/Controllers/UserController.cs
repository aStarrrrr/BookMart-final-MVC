using Microsoft.AspNetCore.Mvc;

namespace BookMart.Controllers
{
    public class UserController : Controller
    {
        public IActionResult userhome()
        {
            return View();
        }
        public IActionResult usercart()
        {
            return View();
        }
        public IActionResult userorder()
        {
            return View();
        }
        public IActionResult userprofile()
        {
            return View();
        }
        public IActionResult userviewbookdetails()
        {
            return View();
        }
    }
}
