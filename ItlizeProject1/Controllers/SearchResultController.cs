using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using ItlizeProject1.Models;
using ItlizeProject1.ViewModel;


namespace ItlizeProject1.Controllers
{
    public class SearchResultController : Controller
    {
        private ISubcategoryRepository Isubcategory;
        private IPropertyTagRepository IpropertyTag;
        private IPropertyTagOptionRepository IpropertyTagOption;
        private ITechnicalSpecificationTagRepository ItechnicalSpecificationTag;
        private IPropertyRepository Iproperty;
        private ITechnicalSpecificationRepository ItechnicalSpecification;
        private IProductRepository Iproduct;

        public SearchResultController()
        {
            Isubcategory = new SubcategoryRepository(new ProjectDatabaseANPEntities());
            IpropertyTagOption = new PropertyTagOptionRepository(new ProjectDatabaseANPEntities());
            IpropertyTag = new PropertyTagRepository(new ProjectDatabaseANPEntities());
            ItechnicalSpecificationTag = new TechnicalSpecificationTagRepository(new ProjectDatabaseANPEntities());
            Iproperty = new PropertyRepository(new ProjectDatabaseANPEntities());
            ItechnicalSpecification = new TechnicalSpecificationRepository(new ProjectDatabaseANPEntities());
            Iproduct = new ProductRepository(new ProjectDatabaseANPEntities());
        }
        public ActionResult SearchResult()
        {
            SearchResultVM srvm = new SearchResultVM();
            srvm.SubCategories = Isubcategory.GetAll().ToList();
            srvm.PropertyTags = IpropertyTag.GetAll().ToList();
            srvm.PropertyTagOptions = IpropertyTagOption.GetAll().ToList();
            srvm.TechnicalSpecificationTags = ItechnicalSpecificationTag.GetAll().ToList();
            srvm.Properties = Iproperty.GetAll().ToList();
            srvm.TechnicalSpecifications = ItechnicalSpecification.GetAll().ToList();
            srvm.Products = Iproduct.GetAll().ToList();
            return View(srvm);
        }
    }
}