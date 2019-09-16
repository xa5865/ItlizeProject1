using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItlizeProject1.Models;
using ItlizeProject1.ViewModel;


//using ItlizeProjectMVC.Dal;


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
        //private ProjectDatabaseANPEntities DBcontext;

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
            //UserData UD1 = new UserData();
            //Login obj = new Login();
            //obj.Username = Request.Form["L1.Username"];
            //obj.Password = Request.Form["L1.Password"];
            if (ModelState.IsValid)
            {
                var x =Iuser.GetById(int.Parse(obj.L1.Username));
                //if (obj.L1.Username == "admin" & obj.L1.Password == "admin")
                if (x == null)
                {
                    obj.L1.Message = "Account is not valid";
                    return View("login",obj);
                }
                else if (x.User_Password == obj.L1.Password)
                {
                    Session["username"] = obj.L1.Username;
                    //Cookies
                    //Login obj1 = new Login { Message = "1 is ok" };
                    //return View("Search");

                    Response.Write("<script>alert('dsafasdf');</script>");
                    Response.Write(@"<script language='javascript'>alert('Message: \n" + "Hi!" + " .');</script>");
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
                   // if (Request.Files.Count > 0)
                    //{
                        HttpPostedFileBase pic = Request.Files["file1"];
                        pic.SaveAs(@"C:\Users\54784\Source\Repos\xa5865\ItlizeProject1\ItlizeProject1\image\" + pic.FileName);
                        var picname = "../../image/" + pic.FileName;
                        //newuser.User_Avatar = picname;
                    //}
                newuser.User_FirstName = obj.Nw1.Name1;
                newuser.User_LastName = obj.Nw1.Name2;
                newuser.User_Password = obj.Nw1.Password2;
                newuser.User_Email = obj.Nw1.Email1;
                newuser.User_Phone = int.Parse(obj.Nw1.Phone1);
                Iuser.Add(newuser);
                    //Login obj1 = new Login { Message = "2 is ok" };
                    return View("login");
                    //return RedirectToAction("Search", "Search");
                }
            }
            else
            {
                return View("login", obj);
            }

        }
    }
}