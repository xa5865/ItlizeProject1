//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItlizeProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property_Tag
    {
        public int Property_Tag_ID { get; set; }
        public string Property_Tag_Name { get; set; }
        public int SubCategory_ID { get; set; }
    
        public virtual SubCategory SubCategory { get; set; }
    }
}