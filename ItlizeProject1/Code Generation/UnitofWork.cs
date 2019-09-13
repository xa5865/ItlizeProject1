using System;
using ItlizeProject1;
using ItlizeProject1.Models;

public class UnitOfWork : IUnitOfWork
{
    private ProjectDatabaseANPEntities _context;

    public UnitOfWork(ProjectDatabaseANPEntities context)
    {
        _context = context;
    }

    //Delete this default constructor if using an IoC container
    public UnitOfWork()
    {
        _context = new ProjectDatabaseANPEntities();
    }

    public ISubcategoryRepository SubCategorys
    {
        get { return new SubcategoryRepository(_context); }
    }

    public IDocumentRepository Documents
    {
        get { return new DocumentRepository(_context); }
    }

    public IManufacturerRepository Manufacturers
    {
        get { return new ManufacturerRepository(_context); }
    }

    public ISaleRepository Sales
    {
        get { return new SaleRepository(_context); }
    }

    public IDepartmentRepository Departments
    {
        get { return new DepartmentRepository(_context); }
    }

    public ICategoryRepository Categorys
    {
        get { return new CategoryRepository(_context); }
    }

    public IPropertyTagRepository Property_Tags
    {
        get { return new PropertyTagRepository(_context); }
    }

    public ITechnicalSpecificationRepository Technical_Specifications
    {
        get { return new TechnicalSpecificationRepository(_context); }
    }

    public IPropertyRepository Propertys
    {
        get { return new PropertyRepository(_context); }
    }

    public IProductRepository Products
    {
        get { return new ProductRepository(_context); }
    }

    public ITechnicalSpecificationTagRepository Technical_Specification_Tags
    {
        get { return new TechnicalSpecificationTagRepository(_context); }
    }

    public IUserRepository Users
    {
        get { return new UserRepository(_context); }
    }


    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
