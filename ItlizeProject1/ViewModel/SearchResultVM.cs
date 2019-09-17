using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItlizeProject1.ViewModel
{
    public class SearchResultVM
    {
        // SubCategory Model
        public int SubCategory_ID { get; set; }
        public string SubCategory_Name { get; set; }
        public int Category_ID { get; set; }

        // Technical Specification Tag Model
        public int Technical_Specification_Tag_ID { get; set; }
        public string Technical_Specification_Tag_Name { get; set; }
        public double TST_Min { get; set; }
        public double TST_Max { get; set; }

        // Property Tag Model
        public int Property_Tag_ID { get; set; }
        public string Property_Tag_Name { get; set; }

        // Property Tag Option Model
        public int Property_Tag_Option_ID { get; set; }
        public string Property_Tag_Option_Name { get; set; }

        // Product Model
        public int Product_ID { get; set; }
        public int Manufacturer_ID { get; set; }
        public string Product_Name { get; set; }
        public byte[] Product_Image { get; set; }
        public int Document_ID { get; set; }
        public int Sales_ID { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }

        // Property Model
        public int Property_ID { get; set; }
        public string Property_Name { get; set; }
        public string Property_Value { get; set; }

        // Technical Specification Model
        public int Tech_Spec_ID { get; set; }
        public string Tech_Spec_Name { get; set; }
        public Nullable<double> Tech_Spec_Value { get; set; }
        public Nullable<double> TS_Min { get; set; }
        public Nullable<double> TS_Max { get; set; }
    }
}