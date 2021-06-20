using Book_A_Room.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_A_Room.Controllers
{
    [Authorize(Roles = MyConstants.RoleUser)]
    public class UserController : Controller
    {
        ApplicationDbContext db;
        public UserController()
        {
            db = new ApplicationDbContext();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult ViewAvailableRooms()
        {
            var availableRooms = db.availableRooms.ToList();
            return View(availableRooms);
        }



    }
}