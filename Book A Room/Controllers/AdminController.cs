using System.Linq;
using System.Web.Mvc;
using Book_A_Room.Models;
using Book_A_Room.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Book_A_Room.Controllers
{
    [Authorize(Roles = MyConstants.RoleAdmin)]
    public class AdminController : Controller
    {
        private ApplicationDbContext db;

        public AdminController()
        {
            db = new ApplicationDbContext();
        }
        //Add User View
        public ActionResult AddUser()
        {
            var roles = db.Roles.ToList();
            roles.Remove(db.Roles.Find("0eb1dfe4-3830-4956-867b-40a1f121c3cc"));
            var viewmodelUserRole = new NewUserRole
            {
                roles = roles,
            };

            return View(viewmodelUserRole);
        }
        //View Users 
        public ActionResult ViewUsers()
        {
            var users = db.Users.ToList();
            return View(users);
        }


        [HttpPost]
        public ActionResult AddUserToDB(RegisterViewModel registerViewModel)
        {


            if (!ModelState.IsValid)
            {

                var roles = db.Roles.ToList();

                var viewmodelUserRole = new NewUserRole
                {
                    roles = roles,
                    registerViewModel = registerViewModel
                };
                return View("AddUser", viewmodelUserRole);
            }

            var users = db.Users.ToList();
            var emails = users.Select(c => c.Email).ToList();

            if (emails.Contains(registerViewModel.Email))
            {
                ModelState.AddModelError("Email", "Email Already Exist");
                var roles = db.Roles.ToList();
                var viewmodelUserRole = new NewUserRole
                {
                    roles = roles,
                    registerViewModel = registerViewModel
                };
                return View("AddUser", viewmodelUserRole);
            }

            if (registerViewModel.RoleID == "66825a12-77e0-4a6f-bbc0-3932ab81caee")
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new ApplicationUserManager(userStore);

                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email
                };
                userManager.Create(newUser, registerViewModel.Password);
                userManager.AddToRole(newUser.Id, MyConstants.RoleMM);
                db.SaveChanges();
            }
            if (registerViewModel.RoleID == "40ba37b0-e373-4fd5-bb7a-281d4731ff6c")
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new ApplicationUserManager(userStore);

                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email
                };
                userManager.Create(newUser, registerViewModel.Password);
                userManager.AddToRole(newUser.Id, MyConstants.RoleHR);
                db.SaveChanges();

            }
            if (registerViewModel.RoleID == "06e782c3-4f43-4d27-9b62-129b439f167a")
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new ApplicationUserManager(userStore);

                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email
                };
                userManager.Create(newUser, registerViewModel.Password);
                userManager.AddToRole(newUser.Id, MyConstants.RoleUser);
                db.SaveChanges();

            }

            return RedirectToAction("ViewUsers", "Admin");
        }
        
       
       

    }
}