using Book_A_Room.Models;
using Book_A_Room.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace Book_A_Room.Controllers
{
    [Authorize(Roles = MyConstants.RoleHR)]

    public class HRController : Controller
    {



        ApplicationDbContext db;
        public HRController()
        {
            db = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //Home Page for the HR Admin
        public ActionResult Index()
        {
            ViewBag.message = "Welcome to trains list!";
            return View();
        }

        /// /////////////////////////////////////////////////

        //Rooms
        //View Rooms In Usal
        public ActionResult ViewRooms()
        {
            var rooms = db.rooms.ToList();
            return View(rooms);
        }
        //Delete Room
        public ActionResult DeleteRoom(int ID)
        {

            if (ModelState.IsValid)
            {
                using (db)
                {

                    var room = db.rooms.Where(t => t.RoomId == ID).FirstOrDefault();
                    db.rooms.Remove(room);
                    db.SaveChanges();
                    RedirectToAction("ViewRooms", "HR");

                }
            }
            return RedirectToAction("ViewRooms", "HR");
        }

        //View Form To Add A Rooms
        public ActionResult AddRoomToDB()
        {
            return View();
        }

        //get values and push to database
        [HttpPost]
        public ActionResult AddRoomToDb(Room room)
        {
            if (ModelState.IsValid)
            {
                db.rooms.Add(room);
                db.SaveChanges();
                RedirectToAction("ViewRooms", "HR");
            }

            return RedirectToAction("ViewRooms", "HR");
        }
        //Delete room

        /// ////////////////////////////////////////////////////


        //View Items in Usal
        public ActionResult ViewItems()
        {
            var items = db.items.ToList();
            return View(items);

        }
        public ActionResult AddItemsForm()
        {
            return View();
        }
        //Add items to DB
        public ActionResult AddItemsToDB(Item item)
        {
            if (ModelState.IsValid)
            {
                var items = db.items.ToList();
                var itemNames = items.Select(m => m.ItemName);
                if (itemNames.Contains(item.ItemName))
                {
                   
                }

                else
                {
                    db.items.Add(item);
                    db.SaveChanges();
                    RedirectToAction("ViewItems", "HR");
                }



            }

            return RedirectToAction("ViewItems","HR");
        } 
        //Delete Item

        public ActionResult DeleteItem(int ID)
        {
            if (ModelState.IsValid)
            {
                using (db)
                {

                    var item = db.items.Where(t => t.ItemId == ID).FirstOrDefault();
                    db.items.Remove(item);
                    db.SaveChanges();
                    RedirectToAction("ViewItems", "HR");

                }
            }
            return RedirectToAction("ViewItems", "HR");
        }

        /// ////////////////////////////////////////////////////////////////////

        //View available rooms

        public ActionResult ViewAvailableRoom()
        {
            var avalableRoom = db.availableRooms.ToList();

            return View(avalableRoom);
        }
        //Form view to add room


        public ActionResult AvailableRoomsForm()
        {
            var rooms = db.rooms.ToList() ;
            var viewmodelAvailableRoom = new NewRoom
            {
                rooms_ = rooms,
            };

            return View(viewmodelAvailableRoom);
        }
        [HttpPost]
        public ActionResult AddAvailableRoomToDb(AvailableRoom available)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.availableRooms.Add(available);
                    db.SaveChanges();
                }catch(Exception ex)
                {
                  
                }


            }
            return View("ViewAvailableRoom","HR");
        }
        
        //delete aval room 
        public ActionResult DeleteAvailableRoom(int ID)
        {
            if (ModelState.IsValid)
            {
                using (db)
                {
                    var availableRoom = db.availableRooms.Where(t => t.AvailableRoomId == ID).FirstOrDefault();
                    db.availableRooms.Remove(availableRoom);
                    db.SaveChanges();
                    RedirectToAction("ViewAvailableRooms", "HR");
                }

            }
            return View("ViewAvailableRoom", "HR");

        }
      


    }
}