
    
using ItlizeProject1.Models;
using System.Collections.Generic;
using System.Linq;

public class SubcategoryRepository : Repository<SubCategory>, ISubcategoryRepository
{
    private ProjectDatabaseANPEntities _context;

    public SubcategoryRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<SubCategory> getSubByCatID(int cateID) {
        return _context.Set<SubCategory>().ToList().Where(p => p.Category_ID == cateID);
    }
    //Override any generic method for your own custom implemention, add new repository methods to the ISubcategoryRepository.cs file
}
