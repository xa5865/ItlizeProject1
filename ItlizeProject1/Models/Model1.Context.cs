﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItlizeProject1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using ItlizeProject1.Models;

    public partial class ProjectDatabaseANPEntities : DbContext
    {
        public ProjectDatabaseANPEntities()
            : base("name=ProjectDatabaseANPEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Property_Tag> Property_Tag { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Technical_Specification> Technical_Specification { get; set; }
        public virtual DbSet<Technical_Specification_Tag> Technical_Specification_Tag { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
