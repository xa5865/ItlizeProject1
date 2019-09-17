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
    IPropertyTagOptionRepository Property_Tag_Options { get; }
    ITechnicalSpecificationRepository Technical_Specifications { get; }
    ILoginRepository Logins { get; }
    IPropertyRepository Propertys { get; }
    IProductRepository Products { get; }
    INewuserRepository NewUsers { get; }
    ITechnicalSpecificationTagRepository Technical_Specification_Tags { get; }
    IUserRepository Users { get; }
    void Save();
}
