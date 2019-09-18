using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItlizeProject1.Controllers
{
    public class _LayoutController : Controller
    {
        // GET: _Layout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Login");
        }
    }
}