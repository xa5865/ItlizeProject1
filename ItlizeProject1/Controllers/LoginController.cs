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
                Login obj1 = new Login { Message = "1 is ok" };
                return View("login2", obj1);
            }
            
        }

        public ActionResult Submit(UserData obj)
        {
            obj.L1.Message = null;
            if (ModelState.IsValid)
            {
                var x =Iuser.GetById(int.Parse(obj.L1.Username));
                if (x == null)
                {
                    obj.L1.Message = "Account is not valid";
                    return View("login",obj);
                }
                else if (x.User_Password == obj.L1.Password)
                {
                    HttpCookie cookie1 = new HttpCookie("username");
                    HttpCookie cookie2 = new HttpCookie("password");
                    Response.Cookies["username"].Value = obj.L1.Username;
                    Response.Cookies["password"].Value = obj.L1.Password;
                    Session["username"] = obj.L1.Username;
                    return RedirectToAction("Search", "Search");
                }
                else
                {
                    obj.L1.Message = "Password is not right";
                    return View("login",obj);
                }
            }
            else
            {
                return View("login",obj);
            }
        }
        
        public ActionResult Submit2(UserData obj)
        {
            if (ModelState.IsValid)
            {

                obj.Nw1.Message = null;
                var newuser = new User();
                newuser.User_ID = int.Parse(obj.Nw1.Username2);
                var x = Iuser.GetById(int.Parse(obj.Nw1.Username2));
                if (x != null)
                {
                    obj.Nw1.Message = "Account is already existed";
                    return View("login",obj);
                }
                else {
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
                    return View("login");
                }
            }
            else
            {
                return View("login", obj);
            }

        }
    }
}