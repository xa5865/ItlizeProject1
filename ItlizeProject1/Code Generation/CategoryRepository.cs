
using ItlizeProject1;
using ItlizeProject1.Models;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private ProjectDatabaseANPEntities _context;

    public CategoryRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICategoryRepository.cs file
}
