                
using ItlizeProject1.Models;
              
public class PropertyTagOptionRepository : Repository<Property_Tag_Option>, IPropertyTagOptionRepository
{
    private ProjectDatabaseANPEntities _context;

    public PropertyTagOptionRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IPropertyTagOptionRepository.cs file
}
