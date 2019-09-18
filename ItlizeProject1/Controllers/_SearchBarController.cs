using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using ItlizeProject1.Models;
using ItlizeProject1.ViewModel;

namespace ItlizeProject1.Controllers
{
 
    public class _SearchBarController : Controller
    {
        private ICategoryRepository ICate;
        private ISubcategoryRepository ISub;
        // Constructor
        public _SearchBarController()
        {
            this.ICate = new CategoryRepository(new ProjectDatabaseANPEntities());
            this.ISub = new SubcategoryRepository(new ProjectDatabaseANPEntities());
        }

        // GET: _SearchBar

        public ActionResult _SearchBar()
        {
            SearchBarVM searchBarVMs = new SearchBarVM
            {
                cat = new List<Category>(),
                sub = new List<SubCategory>()
            };

            searchBarVMs.cat = ICate.GetAll().ToList();
            searchBarVMs.sub = ISub.GetAll().ToList();

            return PartialView(searchBarVMs);
  
        }

        [HttpPost]
        public ActionResult Submit(FormCollection collection)
        {
            string category = Request.Form["SelectedCat"];
            string subcategory = Request.Form["SelectedSub"];

            return RedirectToAction("SearchResult", "SearchResult");
        }

       
    }
}