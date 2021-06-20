using Book_A_Room.Models;
using System.Web.Mvc;

namespace Book_A_Room.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole(MyConstants.RoleAdmin))
            {
                return RedirectToAction("HomePageAdmin", "Home");
            }else if (User.IsInRole(MyConstants.RoleUser))
            {
                return RedirectToAction("HomePageUser", "Home");
            }
            else if (User.IsInRole(MyConstants.RoleHR))
            {
                return RedirectToAction("Index", "HR");
            }
            else if (User.IsInRole(MyConstants.RoleMM))
            {
                return RedirectToAction("HomePageMM", "Home");
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //AdminHomePage
        [Authorize(Roles =MyConstants.RoleAdmin)]
        public ActionResult HomePageAdmin()
        {
            return View();
        }
        




        //UserHomePage
        [Authorize(Roles = MyConstants.RoleUser)]
        public ActionResult HomePageUser()
        {
            return View();
        }
        //HRHomePage
        [Authorize(Roles = MyConstants.RoleHR)]
        public ActionResult HomePageHR()
        {
            return View();
        }
        //MMHomePage
        [Authorize(Roles = MyConstants.RoleMM)]
        public ActionResult HomePageMM()
        {
            return View();
        }
    }
}