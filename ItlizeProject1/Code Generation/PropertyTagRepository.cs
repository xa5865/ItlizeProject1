                
using ItlizeProject1.Models;
              
public class PropertyTagRepository : Repository<Property_Tag>, IPropertyTagRepository
{
    private ProjectDatabaseANPEntities _context;

    public PropertyTagRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IPropertyTagRepository.cs file
}
