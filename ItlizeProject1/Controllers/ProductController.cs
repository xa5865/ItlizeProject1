using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItlizeProject1.Models;
using ItlizeProject1.ViewModel;

namespace ItlizeProject1.Controllers
{
    public class ProductController : Controller
    {
        private IManufacturerRepository manufacturer;
        private IProductRepository product;
        private IPropertyRepository property;
        private IDocumentRepository document;
        private ITechnicalSpecificationRepository technicalSpecification;
        private ISaleRepository sale;
        private IDepartmentRepository department;
        public ProductController()
        {
            this.manufacturer = new ManufacturerRepository(new ProjectDatabaseANPEntities());
            this.product = new ProductRepository(new ProjectDatabaseANPEntities());
            this.property = new PropertyRepository(new ProjectDatabaseANPEntities());
            this.document = new DocumentRepository(new ProjectDatabaseANPEntities());
            this.technicalSpecification = new TechnicalSpecificationRepository(new ProjectDatabaseANPEntities());
            this.sale = new SaleRepository(new ProjectDatabaseANPEntities());
            this.department = new DepartmentRepository(new ProjectDatabaseANPEntities());
        }
        // GET: Product

        [OutputCache(Duration = 600)]
        public ActionResult Product(int id)
        {
            if (Session["username"] != null)
            {
                ProductSummary ps1 = new ProductSummary
                {
                    productid = id
                };
                ps1.Pdt = product.GetById(ps1.productid);
                ps1.Pro = property.GetById(ps1.productid);
                ps1.Maf = manufacturer.GetById(ps1.productid);
                ps1.Doc = document.GetById(ps1.Pdt.Document_ID);
                ps1.sale = sale.GetById(ps1.productid);
                ps1.department = department.GetById(ps1.Maf.Manufacturer_ID);
                ps1.technical_Specifications = technicalSpecification.GetAll().Where(x => x.Product_ID == ps1.productid).ToList();
                ps1.properties = property.GetAll().Where(x => x.Product_ID == ps1.productid).ToList();
                ps1.documents = document.GetAll().Where(x => x.Product_ID == ps1.productid).ToList();
                return View(ps1);
            }
            else
                return RedirectToAction("Login", "Login");
        }
    }
}