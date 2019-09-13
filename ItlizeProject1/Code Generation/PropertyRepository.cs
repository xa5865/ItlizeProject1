                
using ItlizeProject1.Models;
              
public class PropertyRepository : Repository<Property>, IPropertyRepository
{
    private ProjectDatabaseANPEntities _context;

    public PropertyRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IPropertyRepository.cs file
}
