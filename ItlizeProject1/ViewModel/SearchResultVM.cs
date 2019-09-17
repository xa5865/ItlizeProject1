using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.ViewModel
{
    public class SearchResultVM
    {
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public IEnumerable<Property_Tag> PropertyTags { get; set; }
        public IEnumerable<Property_Tag_Option> PropertyTagOptions { get; set; }
        public IEnumerable<Technical_Specification_Tag> TechnicalSpecificationTags { get; set; }
        public IEnumerable<Technical_Specification> TechnicalSpecifications { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}