using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItlizeProject1.Models;

namespace ItlizeProject1.ViewModel
{
    public class SearchBarVM
    {
        public Category category { get; set; }
        public SubCategory subCategory { get; set; }
        public List<Category> cat { get; set; }

        public List<SubCategory> sub { get; set; }
    }
}