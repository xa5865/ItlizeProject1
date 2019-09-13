            using System;

public interface IUnitOfWork : IDisposable
{
    ISubcategoryRepository SubCategorys { get; }
    IDocumentRepository Documents { get; }
    IManufacturerRepository Manufacturers { get; }
    ISaleRepository Sales { get; }
    IDepartmentRepository Departments { get; }
    ICategoryRepository Categorys { get; }
    IPropertyTagRepository Property_Tags { get; }
    ITechnicalSpecificationRepository Technical_Specifications { get; }
    IPropertyRepository Propertys { get; }
    IProductRepository Products { get; }
    ITechnicalSpecificationTagRepository Technical_Specification_Tags { get; }
    IUserRepository Users { get; }
    void Save();
}
