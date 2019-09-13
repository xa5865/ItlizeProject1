                
using ItlizeProject1.Models;
              
public class TechnicalSpecificationRepository : Repository<Technical_Specification>, ITechnicalSpecificationRepository
{
    private ProjectDatabaseANPEntities _context;

    public TechnicalSpecificationRepository(ProjectDatabaseANPEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ITechnicalSpecificationRepository.cs file
}
