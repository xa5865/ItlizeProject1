using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.ViewModel
{
    public class ProductSummary
    {
        public Product Pdt { get; set; }

        public Property Pro { get; set; }

        public Technical_Specification Tec { get; set; }

        public Document Doc { get; set; }

        public Manufacturer Maf { get; set; }

        public Sale sale { get; set; }

        public Department department { get; set; }

        public int productid { get; set; }

        public List<Technical_Specification> technical_Specifications { get; set; }

        public List<Property> properties { get; set; }

        public List<Document> documents { get; set; }
    }
}