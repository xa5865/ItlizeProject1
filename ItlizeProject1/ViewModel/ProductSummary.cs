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

        public int productid { get; set; }

        public List<Technical_Specification> ts { get; set; }
    }
}