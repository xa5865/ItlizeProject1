                
using ItlizeProject1.Models;
              
public class ProductRepository : Repository<Product>, IProductRepository
{
    private ProjectDatabaseANPEntities _context;

    public ProductRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IProductRepository.cs file
}
