using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItlizeProject1.Models;
using ItlizeProject1.ViewModel;

namespace ItlizeProject1.Controllers
{
    public class LoginController : Controller
    {
        private IUserRepository Iuser;
        private List<User> users;
        public LoginController()

        {
            this.Iuser = new UserRepository(new ProjectDatabaseANPEntities());
        }
        // GET: Login

        public ActionResult Load()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Session["username"] == null)
            {
                UserData obj = new UserData
                {
                    L1 = new Login(),
                    Nw1 = new NewUser()
                };
                return View(obj);
            }
            else
            {
                //search
                return RedirectToAction("Search", "Search");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(UserData obj)
        {
            obj.L1.Message = null;
            if (ModelState.IsValid)
            {
                if (int.TryParse(obj.L1.Username, out int tuser) == true)
                    users = Iuser.GetAll().Where(x => x.User_ID == tuser).ToList();
                else
                {
                    users = Iuser.GetAll().Where(x => x.User_Email == obj.L1.Username).ToList();
                }
                if ((users == null) || (users.Count == 0))
                {
                    obj.L1.Message = "Account is not valid";
                    return View("login", obj);
                }
                else if (users[0].User_Password == obj.L1.Password)
                {
                    Response.Cookies["username"].Value = users[0].User_ID.ToString();
                    Response.Cookies["password"].Value = obj.L1.Password;
                    Session["username"] = users[0].User_ID;
                    Session["pic"] = users[0].User_Avatar;
                    return RedirectToAction("Search", "Search");
                    // return RedirectToAction("Product", "Product",new {id = 1 });
                }
                else
                {
                    obj.L1.Message = "Password is not right";
                    return View("login", obj);
                }
            }
            else
            {
                return View("login", obj);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit2(UserData obj)
        {
            if (ModelState.IsValid)
            {
                obj.Nw1.Message = null;
                var newuser = new User
                {
                    User_ID = int.Parse(obj.Nw1.Username2)
                };
                var x = Iuser.GetById(int.Parse(obj.Nw1.Username2));
                users = Iuser.GetAll().Where(z => z.User_Email == obj.Nw1.Email1).ToList();
                if (x != null)
                {
                    obj.Nw1.Message = "Account is already existed";
                    return View("login", obj);
                }
                if (users.Count != 0)
                {
                    obj.Nw1.Message = "Email is already existed";
                    return View("login", obj);
                }
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase pic = Request.Files["file1"];
                    var picname = newuser.User_ID + "_" + pic.FileName;
                    pic.SaveAs(@"C:\Users\54784\Source\Repos\xa5865\ItlizeProject1\ItlizeProject1\image\" + picname);
                    newuser.User_Avatar = picname;
                }
                newuser.User_FirstName = obj.Nw1.Name1;
                newuser.User_LastName = obj.Nw1.Name2;
                newuser.User_Password = obj.Nw1.Password2;
                newuser.User_Email = obj.Nw1.Email1;
                newuser.User_Phone = int.Parse(obj.Nw1.Phone1);
                Iuser.InsertNewUser(newuser);
                obj.Nw1.Message = "Account register successfully!";
                return View("login", obj);
            }
            else
            {
                return View("login", obj);
            }

        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            Session["pic"] = null;
            return RedirectToAction("Login", "Login");
        }
    }
}