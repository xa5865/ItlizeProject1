
    
using ItlizeProject1.Models;
              
public class SubcategoryRepository : Repository<SubCategory>, ISubcategoryRepository
{
    private ProjectDatabaseANPEntities _context;

    public SubcategoryRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISubcategoryRepository.cs file
}
